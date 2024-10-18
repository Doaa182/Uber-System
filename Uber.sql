CREATE TABLE Passenger (
    p_id NUMBER(30) PRIMARY KEY,
    p_phone_no VARCHAR2(30),
    p_e_wallet_no VARCHAR2(30) UNIQUE,
    p_email VARCHAR2(30),
    p_password VARCHAR2(30),
    p_name VARCHAR2(30),
    p_last_canceled_trip VARCHAR2(30),
    p_fine NUMBER(30) DEFAULT 0,
    p_trip_count NUMBER(30) DEFAULT 0,
    p_rating NUMBER(30),
    p_isDeleted NUMBER (1),
    p_language VARCHAR2(30) 
);
CREATE TABLE Driver (
d_id NUMBER(30) PRIMARY KEY,
d_phone_no VARCHAR2(30),
d_e_wallet_no VARCHAR2(30) ,
d_email VARCHAR2(30)   ,
d_password VARCHAR2(30)  ,
d_name VARCHAR2(30)  ,
d_last_canceled_trip VARCHAR2(30),
d_fine NUMBER(30) DEFAULT 0,
d_trip_count NUMBER(30) DEFAULT 0,
d_rating NUMBER(30),
d_isDeleted NUMBER (1),
d_car_type VARCHAR2(30)  ,
d_car_model VARCHAR2(30),
d_plate_no VARCHAR2(30)   ,
d_avail_status NUMBER(1)  
);
CREATE TABLE Trip_Requests (
t_id NUMBER(30) PRIMARY KEY,
ps_id NUMBER(30),
estimated_cost NUMBER(30),
start_location VARCHAR2(30),
destination VARCHAR2(30),
ride_type  VARCHAR2(30),
trip_start_time  VARCHAR2(30)  ,
estimated_end_time  VARCHAR2(30) ,
payment_method VARCHAR2(30),
trip_status VARCHAR2(30),
promocode VARCHAR2(30),

CONSTRAINT passenger_id_FK FOREIGN KEY (ps_id) REFERENCES Passenger(p_id)
);
CREATE TABLE Accepted_Trip_Requests (
t_id NUMBER(30) PRIMARY KEY,
ps_id NUMBER(30),
dr_id NUMBER(30),
estimated_cost NUMBER(30),
start_location VARCHAR2(30),
destination VARCHAR2(30),
ride_type  VARCHAR2(30),
trip_start_time  VARCHAR2(30)  ,
estimated_end_time  VARCHAR2(30) ,
payment_method VARCHAR2(30),
trip_status VARCHAR2(30),
promocode VARCHAR2(30),

CONSTRAINT passenger_id_FKK FOREIGN KEY (ps_id) REFERENCES Passenger(p_id),
CONSTRAINT driver_id_FKK FOREIGN KEY (dr_id) REFERENCES Driver(d_id)

);
CREATE TABLE Compeleted_Trips (
t_id NUMBER(30) PRIMARY KEY NOT NULL,
ps_id NUMBER(30),
dr_id NUMBER(30),
actual_cost NUMBER(30) NOT NULL,
start_location VARCHAR2(30),
final_destination VARCHAR2(30),
ride_type  VARCHAR2(30),
trip_start_time Date  ,
trip_end_time Date ,
payment_method VARCHAR2(30),
p_review VARCHAR2(30),
promocode VARCHAR2(30),

CONSTRAINT tid3_FK FOREIGN KEY (ps_id) REFERENCES Passenger(p_id),
CONSTRAINT tid4_FK FOREIGN KEY (dr_id) REFERENCES Driver(d_id)
);
CREATE TABLE Canceled_Requests (
t_id NUMBER(30) PRIMARY KEY NOT NULL,
ps_id NUMBER(30),
dr_id NUMBER(30),
estimated_cost NUMBER(30) NOT NULL,
start_location VARCHAR2(30),
destination VARCHAR2(30),
ride_type  VARCHAR2(30),
trip_start_time Date  ,
estimated_end_time Date ,
payment_method VARCHAR2(30),
cancelation_time VARCHAR2(30),
promocode VARCHAR2(30),

CONSTRAINT tid5_FK FOREIGN KEY (ps_id) REFERENCES Passenger(p_id),
CONSTRAINT tid6_FK FOREIGN KEY (dr_id) REFERENCES Driver(d_id)
);


CREATE SEQUENCE passenger_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE driver_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE trip_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE accepted_trips_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE canceled_trips_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE completed_trips_seq START WITH 1 INCREMENT BY 1;


CREATE TRIGGER passenger_trigger
BEFORE INSERT ON Passenger
FOR EACH ROW
BEGIN
    SELECT passenger_seq.NEXTVAL INTO :new.p_id FROM dual;
END;

CREATE TRIGGER completed_trips_trigger
BEFORE INSERT ON Compeleted_Trips
FOR EACH ROW
BEGIN
    SELECT completed_trips_seq.NEXTVAL INTO :new.t_id FROM dual;
END;

CREATE TRIGGER cancel_req_trigger
BEFORE INSERT ON Canceled_Requests
FOR EACH ROW
BEGIN
    SELECT canceled_trips_seq.NEXTVAL INTO :new.t_id FROM dual;
END;

CREATE TRIGGER driver_trigger
BEFORE INSERT ON Driver
FOR EACH ROW
BEGIN
    SELECT driver_seq.NEXTVAL INTO :new.d_id FROM dual;
END;

CREATE TRIGGER trip_requests_trigger
BEFORE INSERT ON Trip_Requests
FOR EACH ROW
BEGIN
    SELECT trip_seq.NEXTVAL INTO :new.t_id FROM dual;
END;

CREATE TRIGGER accepted_trips_trigger
BEFORE INSERT ON Accepted_Trip_Requests
FOR EACH ROW
BEGIN
    SELECT accepted_trips_seq.NEXTVAL INTO :new.t_id FROM dual;
END;



CREATE OR REPLACE PROCEDURE update_driver (
    driver_id IN VARCHAR2,
    phone_number IN VARCHAR2,
    e_wallet_number IN VARCHAR2,
    email IN VARCHAR2,
    password IN VARCHAR2,
    name IN VARCHAR2,
    car_type IN VARCHAR2,
    car_model IN VARCHAR2,
    plate_number IN VARCHAR2
)
AS
BEGIN
    UPDATE Driver SET 
        d_phone_no = phone_number,
        d_e_wallet_no = e_wallet_number,
        d_email = email,
        d_password = password,
        d_name = name,
        d_car_type = car_type,
        d_car_model = car_model,
        d_plate_no = plate_number
    WHERE d_id = driver_id;
END;

CREATE OR REPLACE PROCEDURE update_passenger (
    passenger_id IN VARCHAR2,
    phone_number IN VARCHAR2,
    e_wallet_number IN VARCHAR2,
    email IN VARCHAR2,
    password IN VARCHAR2,
    name IN VARCHAR2,
    succeeded OUT NUMBER
)
AS
BEGIN
    UPDATE Passenger SET 
        p_phone_no = phone_number,
        p_e_wallet_no = e_wallet_number,
        p_email = email,
        p_password = password,
        p_name = name
    WHERE p_id = passenger_id;
    succeeded = 1;
END;


CREATE OR REPLACE PROCEDURE get_canceled_requests (
  p_id IN NUMBER,
  p_results OUT SYS_REFCURSOR
)
AS
BEGIN
  OPEN p_results FOR
    SELECT * FROM Canceled_Requests
    WHERE ps_id = p_id;
END;




INSERT INTO PASSENGER (p_phone_no, p_email, p_password) VALUES ('010123456', 'test4@gmai.com', '123');

INSERT INTO Trip_Requests (t_id, ps_id, estimated_cost, start_location, destination, ride_type, payment_method, trip_status, promocode)
VALUES (1, 1,  50.00, '123 Main St', '456 Elm St', 'UberX',  'Credit Card', 'Pending', 'SUMMER20');

INSERT INTO Accepted_Trip_Requests (ps_id, dr_id, estimated_cost, start_location, destination, ride_type, trip_start_time, estimated_end_time, payment_method, trip_status, promocode)
VALUES ( 1, 1, 50.00, '123 Main St', '456 Elm St', 'UberX', '2023-04-26 12:00:00', '2023-04-26 12:30:00', 'Credit Card', 'Pending', 'SUMMER20');

INSERT INTO Compeleted_Trips (ps_id, dr_id, actual_cost, start_location, final_destination, ride_type, trip_start_time, trip_end_time, payment_method, p_review, promocode)
VALUES (1, 4, 50.00, '123 Main St', '456 Elm St', 'UberX', TO_DATE('2023-04-28 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE('2023-04-28 09:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'Credit Card', 'Great ride!', 'FIRST10');


INSERT INTO Driver (d_phone_no, d_e_wallet_no, d_email, d_password, d_name, d_car_type, d_car_model, d_plate_no)  
VALUES ('111', '2000', 'test@email.com', '123', 'test_name', 'test2', 'test2', 'test_plate_number');

INSERT INTO Canceled_Requests ( ps_id, estimated_cost, start_location, destination, ride_type, trip_start_time, estimated_end_time, payment_method, cancelation_time, promocode)
VALUES ( 1, 25.50, 'Alex', 'Washington', 'Regular', '01-JAN-97', '01-JAN-98', 'Credit Card', '2023-04-27 14:35:00', 'XYZ123');


DELETE FROM trip_requests WHERE ps_id = 1;

SELECT * FROM accepted_trip_requests;
SELECT * FROM Trip_requests;
SELECT * FROM Compeleted_Trips;
SELECT * FROM DRIVER;
SELECT * FROM passenger;
SELECT * FROM Canceled_Requests;
SELECT * FROM Trip_Requests WHERE  ps_id = 1;
SELECT * FROM Accepted_Trip_Requests WHERE  ps_id = 1;


DELETE FROM Canceled_Requests WHERE ps_id = 1;
DELETE FROM accepted_trip_requests WHERE ps_id = 1;

commit;

SELECT estimated_end_time - trip_start_time AS duration
FROM Canceled_Requests;

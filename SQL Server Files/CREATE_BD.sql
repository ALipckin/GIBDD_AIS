-- Generated by Oracle SQL Developer Data Modeler 22.2.0.165.1149
--   at:        2022-08-01 20:47:52 YEKT
--   site:      SQL Server 2012
--   type:      SQL Server 2012


CREATE TABLE ACCIDENTS 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Num_of_victims INTEGER NOT NULL , 
     Amount_of_damage FLOAT , 
     Reason VARCHAR (30) , 
     Road_conditions VARCHAR (30) , 
     Area VARCHAR (30) NOT NULL , 
     Type VARCHAR (30) NOT NULL , 
     Date DATE NOT NULL 
    )
GO

ALTER TABLE ACCIDENTS ADD CONSTRAINT ACCIDENTS_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE COMPANYS 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Name VARCHAR (30) NOT NULL , 
     Address VARCHAR (30) NOT NULL 
    )
GO

ALTER TABLE COMPANYS ADD CONSTRAINT COMPANYS_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DIRECTORYS 
    (
     Start_D DATE NOT NULL , 
     End_D DATE NOT NULL , 
     Amount INTEGER NOT NULL , 
     ACCIDENTS_ID INTEGER NOT NULL , 
     VICTIMS_ID INTEGER NOT NULL 
    )
GO

ALTER TABLE DIRECTORYS ADD CONSTRAINT DIRECTORYS_PK PRIMARY KEY CLUSTERED (ACCIDENTS_ID, VICTIMS_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE HISTORYS 
    (
     ACCIDENTS_ID INTEGER NOT NULL , 
     Start_D DATE NOT NULL , 
     End_D DATE NOT NULL , 
     Amount INTEGER NOT NULL , 
     VEHICLES_ID INTEGER NOT NULL 
    )
GO

ALTER TABLE HISTORYS ADD CONSTRAINT HISTORYS_PK PRIMARY KEY CLUSTERED (ACCIDENTS_ID, VEHICLES_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE OWNERS 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Surname VARCHAR (30) NOT NULL , 
     Name VARCHAR (30) NOT NULL , 
     Middle_name VARCHAR (30) NOT NULL , 
     Address VARCHAR (30) NOT NULL , 
     Birth_D DATE NOT NULL 
    )
GO

ALTER TABLE OWNERS ADD CONSTRAINT OWNERS_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TI 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Date DATE NOT NULL , 
     VEHICLES_ID INTEGER NOT NULL 
    )
GO

ALTER TABLE TI ADD CONSTRAINT TI_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE USERS 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Login VARCHAR (20) NOT NULL , 
     Password VARCHAR (20) NOT NULL 
    )
GO

ALTER TABLE USERS ADD CONSTRAINT USERS_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE VEHICLES 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Number VARCHAR (9) NOT NULL , 
     VIN CHAR (17) NOT NULL , 
     Brand VARCHAR (30) NOT NULL , 
     Release_D VARCHAR (30) NOT NULL , 
     Engine_volume VARCHAR (30) NOT NULL , 
     Engine_n VARCHAR (30) NOT NULL , 
     Chasis_n VARCHAR (30) NOT NULL , 
     Body_n VARCHAR (30) NOT NULL , 
     Color VARCHAR (30) NOT NULL , 
     Type VARCHAR (30) NOT NULL , 
     COMPANYS_ID INTEGER , 
     OWNERS_ID INTEGER 
    )
GO

ALTER TABLE VEHICLES ADD CONSTRAINT VEHICLES_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE VICTIMS 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Surname VARCHAR (30) NOT NULL , 
     Name VARCHAR (30) NOT NULL , 
     Middle_name VARCHAR (30) NOT NULL , 
     Address VARCHAR (60) NOT NULL 
    )
GO

ALTER TABLE VICTIMS ADD CONSTRAINT VICTIMS_PK PRIMARY KEY CLUSTERED (ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE WANTED 
    (
     ID INTEGER IDENTITY(1,1)NOT NULL , 
     Reason VARCHAR (60) NOT NULL , 
     Date VARCHAR (30) NOT NULL , 
     Activity BIT , 
     VEHICLES_ID INTEGER NOT NULL 
    )
GO

ALTER TABLE WANTED ADD CONSTRAINT WANTED_PK PRIMARY KEY CLUSTERED (ID, VEHICLES_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

ALTER TABLE DIRECTORYS 
    ADD CONSTRAINT DIRECTORYS_ACCIDENTS_FK FOREIGN KEY 
    ( 
     ACCIDENTS_ID
    ) 
    REFERENCES ACCIDENTS 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DIRECTORYS 
    ADD CONSTRAINT DIRECTORYS_VICTIMS_FK FOREIGN KEY 
    ( 
     VICTIMS_ID
    ) 
    REFERENCES VICTIMS 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE HISTORYS 
    ADD CONSTRAINT HISTORYS_ACCIDENTS_FK FOREIGN KEY 
    ( 
     ACCIDENTS_ID
    ) 
    REFERENCES ACCIDENTS 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE HISTORYS 
    ADD CONSTRAINT HISTORYS_VEHICLES_FK FOREIGN KEY 
    ( 
     VEHICLES_ID
    ) 
    REFERENCES VEHICLES 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE TI 
    ADD CONSTRAINT TI_VEHICLES_FK FOREIGN KEY 
    ( 
     VEHICLES_ID
    ) 
    REFERENCES VEHICLES 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE VEHICLES 
    ADD CONSTRAINT VEHICLES_COMPANYS_FK FOREIGN KEY 
    ( 
     COMPANYS_ID
    ) 
    REFERENCES COMPANYS 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE VEHICLES 
    ADD CONSTRAINT VEHICLES_OWNERS_FK FOREIGN KEY 
    ( 
     OWNERS_ID
    ) 
    REFERENCES OWNERS 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE WANTED 
    ADD CONSTRAINT WANTED_VEHICLES_FK FOREIGN KEY 
    ( 
     VEHICLES_ID
    ) 
    REFERENCES VEHICLES 
    ( 
     ID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO



-- Oracle SQL Developer Data Modeler Summary Report: 
-- 
-- CREATE TABLE                            10
-- CREATE INDEX                             0
-- ALTER TABLE                             18
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE DATABASE                          0
-- CREATE DEFAULT                           0
-- CREATE INDEX ON VIEW                     0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE ROLE                              0
-- CREATE RULE                              0
-- CREATE SCHEMA                            0
-- CREATE SEQUENCE                          0
-- CREATE PARTITION FUNCTION                0
-- CREATE PARTITION SCHEME                  0
-- 
-- DROP DATABASE                            0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0

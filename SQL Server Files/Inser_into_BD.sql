insert into USERS(login, password)values('admin','admin')

insert into OWNERS 
    (Surname, Name, Middle_name, Address, Birth_D)
	values('Липкин','Александр','Сергеевич','Екатеринбург, ул. Пушкина 43', '2001-03-27'),
	('Иванов','Иван','Иванович','ул. Октябрьская 65', '1993-05-03')
insert into	VICTIMS 
  (Surname, Name, Middle_name, Address)
  values('Петров','Иван','Кирилович','Екатеринбург, Октябрьская 55')

insert into VEHICLES 
    (Number, VIN, Brand, Release_D , Engine_volume, Engine_n, Chasis_n, Body_n, Color, Type, OWNERS_ID)
	values('C065MK78', '1HFSC3404VA000123', 'BMW X5', '2007.01.03',4.8,'35615697306S3','421','124125qwerty','Черный','Легковой','1'),
	('KMM97678','2C4GJ453XYR693697', 'AUDI Q5', '2007.01.03',4.8,'35615697306S3','421','123456qwerty','Черный','Легковой','2')

insert into ACCIDENTS
	(Num_of_victims, Amount_of_damage, Reason, Road_conditions, Area, Type, Date )
	values(1, 5000, '-', 'Мокрое', 'Екатеринбург', 'Автомобильная', '02.05.2022'),(2, 30000, 'Потому что', 'Плохие', 'Екатеринбург', 'Автомобильная', '02.05.2022')

insert into COMPANYS (Name,  Address)values('Рога и копыта','Ектаринбург, Улица Пушкина, 42')

DECLARE @VEHICLE_ID INT;
SELECT @VEHICLE_ID = ID FROM VEHICLES WHERE ID = SCOPE_IDENTITY();
DECLARE @ACCIDENTS_ID INT;
SELECT @ACCIDENTS_ID = ID FROM ACCIDENTS WHERE ID = SCOPE_IDENTITY();
insert into HISTORYS 
    (Start_D, End_D, Amount,ACCIDENTS_ID,VEHICLES_ID)
	values('2022.06.22','2022.07.30',1000,@ACCIDENTS_ID, @VEHICLE_ID)

insert into DIRECTORYS 
    (Start_D, End_D, Amount, ACCIDENTS_ID, VICTIMS_ID)
	values('13.03.2022','03.05.2022',2,1,1),
	('02.03.2022','03.06.2022',9,2,1)

insert into TI 
    (Date,VEHICLES_ID)
	values('2022-06-21',@VEHICLE_ID),
	('2022-04-05',@VEHICLE_ID)

insert into	WANTED 
  (Reason, Date, Activity, VEHICLES_ID)
  values('Угон','2022.06.22',1,@VEHICLE_ID)
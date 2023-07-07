CREATE TABLE Contract(
	Contract_ID int IDENTITY(1,1) PRIMARY KEY,
	Sign_Date   date,
	End_Date    date,
	First_Name		varChar(30),
	Last_Name		varChar(30),
	Contact_Num		varChar(13)
);

CREATE TABLE Apartment(
    Apartment_ID    int IDENTITY(1,1) PRIMARY KEY,
    Contract_ID		int FOREIGN KEY REFERENCES Contract(Contract_ID),
    Apartment_Num   varchar(3)
);

Create TABLE Facility(
	Facility_ID		int IDENTITY(1,1) PRIMARY KEY,
	Facility_name   varchar(50)
);

CREATE TABLE Facility_in_Apartment(
Apartment_ID	int NOT NULL,
Facility_ID		int NOT NULL,

CONSTRAINT PK_Facility_in_Apartment PRIMARY KEY (Apartment_ID, Facility_ID),
FOREIGN KEY (Apartment_ID) REFERENCES Apartment(Apartment_ID),
FOREIGN KEY (Facility_ID) REFERENCES Facility(Facility_ID)
);

CREATE DATABASE EMRge
GO
USE EMRge
GO

CREATE TABLE Patient
(
    ID VARCHAR(50) PRIMARY KEY,
    FirstName VARCHAR(50),
    MiddleName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(50),
    DateOfBirth DATETIME,
    Email VARCHAR(50),
    PhoneNumber VARCHAR(50) UNIQUE,
    Address VARCHAR(50),
    Nationality VARCHAR(50),
    DateRegistered DATETIME,
    BranchRegistered VARCHAR(50),
    IsInPatient BIT,
    RoomNumber VARCHAR(10),
    ECName VARCHAR(50),
    ECRelation VARCHAR(50),
    ECPhoneNumber VARCHAR(50),
    ECEmail VARCHAR(50),
    BloodType VARCHAR(50),
    Height FLOAT,
    Weight FLOAT,
    IsDeleted BIT DEFAULT 0
)

CREATE TABLE Employee
(
    ID VARCHAR(50) PRIMARY KEY,
    Department VARCHAR(50),
    FirstName VARCHAR(50),
    MiddleName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(50),
    DateOfBirth DATETIME,
    Email VARCHAR(50) UNIQUE,
    PhoneNumber VARCHAR(50) UNIQUE,
    Address VARCHAR(50),
    Nationality VARCHAR(50),
    Branch VARCHAR(50),
    Salary FLOAT,
    DateJoined DATETIME,
    CurrentlyWorking BIT,
    ECName VARCHAR(50),
    ECRelation VARCHAR(50),
    ECPhoneNumber VARCHAR(50),
    ECEmail VARCHAR(50),
    IsDeleted BIT DEFAULT 0
)

CREATE TABLE ExaminationRecord
(
    ID VARCHAR(50) PRIMARY KEY,
    DateAndTime DATETIME,
    PatientID VARCHAR(50),
    PhysicianID VARCHAR(50),
    Diagnosis VARCHAR(MAX),
    IsRemovedFromQueue BIT
)

CREATE TABLE LaboratoryTestRecord
(
    ID VARCHAR(50) PRIMARY KEY,
    ExaminationRecordID VARCHAR(50),
    DateAndTime DATETIME,
    PatientID VARCHAR(50),
    LabPhysicianID VARCHAR(50),
    TestType VARCHAR(50),
    Result VARCHAR(MAX),
    IsRemovedFromQueue BIT
)

CREATE TABLE MedicationRecord
(
    ID VARCHAR(50) PRIMARY KEY,
    ExaminationRecordID VARCHAR(50),
    Medication VARCHAR(50),
    AlternativeMedication VARCHAR(50)
)

SELECT * FROM MedicationRecord

CREATE TABLE EmployeeCredentials
(
    EmployeeID VARCHAR(50) PRIMARY KEY,
    Cred1 BIT,
    Cred2 BIT,
    Cred3 BIT,
    Cred4 BIT,
    Cred5 BIT,
    Cred6 BIT,
    Cred7 BIT,
    Cred8 BIT,
    Cred9 BIT,
    Cred10 BIT,
    Cred11 BIT,
    Cred12 BIT,
    Cred13 BIT,
    Cred14 BIT,
    Cred15 BIT,
    Cred16 BIT,
    Cred17 BIT,
    Password VARCHAR(50)
)


CREATE TABLE Bill (
    ID VARCHAR(50),
    PatientID VARCHAR(50),
    ServiceType VARCHAR(50),
    ServicePrice FLOAT,
    IsPaid BIT DEFAULT 0
)
GO

-------------------------------------------------------
-- PATIENT FUNCTIONS AND PROCEDURES

CREATE PROCEDURE GeneratePatientID
    (@ID VARCHAR(50) OUTPUT)
AS
BEGIN
    SELECT @ID = 'PAT-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM Patient
    WHERE ID = @ID)
        SET @ID = 'PAT-' + (left(replace(newid(),'-',''), 4))
END
GO

CREATE PROCEDURE GetAllOutPatients
AS
SELECT *
FROM Patient
WHERE IsInPatient = 0 AND IsDeleted = 0
GO

CREATE PROCEDURE GetAllInPatients
AS
SELECT *
FROM Patient
WHERE IsInPatient = 1 AND IsDeleted = 0
GO

CREATE PROCEDURE InsertPatient
    (
    @ID VARCHAR(50),
    @FirstName VARCHAR(50),
    @MiddleName VARCHAR(50),
    @LastName VARCHAR(50),
    @Gender VARCHAR(50),
    @DateOfBirth DATETIME,
    @Email VARCHAR(50),
    @PhoneNumber VARCHAR(50),
    @Address VARCHAR(50),
    @Nationality VARCHAR(50),
    @DateRegistered DATETIME,
    @BranchRegistered VARCHAR(50),
    @IsInPatient BIT,
    @RoomNumber VARCHAR(10),
    @ECName VARCHAR(50),
    @ECRelation VARCHAR(50),
    @ECPhoneNumber VARCHAR(50),
    @ECEmail VARCHAR(50),
    @BloodType VARCHAR(50),
    @Height FLOAT,
    @Weight FLOAT
)
AS
INSERT INTO Patient
VALUES
    (@ID, @FirstName, @MiddleName, @LastName, @Gender, @DateOfBirth, @Email, @PhoneNumber, @Address, @Nationality, @DateRegistered, @BranchRegistered, @IsInPatient, @RoomNumber, @ECName, @ECRelation, @ECPhoneNumber, @ECEmail, @BloodType, @Height, @Weight, 0)
GO

CREATE PROCEDURE UpdatePatient
    (
    @ID VARCHAR(50),
    @FirstName VARCHAR(50),
    @MiddleName VARCHAR(50),
    @LastName VARCHAR(50),
    @Gender VARCHAR(50),
    @DateOfBirth DATETIME,
    @Email VARCHAR(50),
    @PhoneNumber VARCHAR(50),
    @Address VARCHAR(50),
    @Nationality VARCHAR(50),
    @ECName VARCHAR(50),
    @ECRelation VARCHAR(50),
    @ECPhoneNumber VARCHAR(50),
    @ECEmail VARCHAR(50),
    @BloodType VARCHAR(50),
    @Height FLOAT,
    @Weight FLOAT
)
AS
UPDATE Patient
    SET FirstName = @FirstName,
        MiddleName = @MiddleName,
        LastName = @LastName,
        Gender = @Gender,
        DateOfBirth = @DateOfBirth,
        Email = @Email,
        PhoneNumber = @PhoneNumber,
        Address = @Address,
        Nationality = @Nationality,
        ECName = @ECName,
        ECRelation = @ECRelation,
        ECPhoneNumber = @ECPhoneNumber,
        @ECEmail = @ECEmail,
        BloodType = @BloodType,
        Height = @Height,
        Weight = @Weight
    WHERE ID = @ID
GO

CREATE PROCEDURE DeletePatient
    (@ID VARCHAR(50))
AS
BEGIN
    UPDATE Patient SET IsDeleted = 1 WHERE ID = @ID
END
GO

CREATE FUNCTION FindPatientByID (@ID VARCHAR(50))
RETURNS TABLE
AS
RETURN
    SELECT *
FROM Patient
WHERE ID = @ID
GO

CREATE FUNCTION FindPatientByPhoneNumber (@PhoneNumber VARCHAR(50))
RETURNS TABLE
AS
RETURN
    SELECT *
FROM Patient
WHERE PhoneNumber = @PhoneNumber
GO


----------------------------------------------------
-- EMPLOYEE FUNCTIONS AND PROCEDURES

CREATE PROCEDURE GetAllEmployees
    (@SearchKey VARCHAR(50),
    @Branch VARCHAR(50),
    @Department VARCHAR(50),
    @MinSalary VARCHAR(50),
    @MaxSalary VARCHAR(50),
    @SortBy VARCHAR(50),
    @Ascending BIT)
AS
BEGIN
    DECLARE @Query VARCHAR(MAX) = 'SELECT * FROM Employee WHERE IsDeleted = 0'
    IF (@SearchKey != '')
        SET @Query += ' AND FirstName = ''' + @SearchKey + ''''
    IF (@Branch != '')
        SET @Query += ' AND Branch = ''' + @Branch + ''''
    IF (@Department != '')
        SET @Query += ' AND Department = ''' + @Department + ''''
    IF (@MinSalary != '')
        SET @Query += ' AND Salary >= ''' + @MinSalary + ''''
    IF (@MaxSalary != '')
        SET @Query += ' AND Salary <= ''' + @MaxSalary + ''''
    IF (@SortBy != '')
    BEGIN
        SET @Query += ' ORDER BY ''' + @SortBy + ''''
        IF (@Ascending = 0)
            SET @Query += ' DESC'
    END

    EXECUTE (@Query)
    PRINT (@Query)
END
GO

CREATE PROCEDURE GenerateEmployeeID
    (@ID VARCHAR(50) OUTPUT)
AS
BEGIN
    SELECT @ID = 'EMP-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM Employee
    WHERE ID = @ID)
        SET @ID = 'EMP-' + (left(replace(newid(),'-',''), 4))
END
GO

CREATE PROCEDURE InsertEmployee
    (
    @ID VARCHAR(50),
    @Department VARCHAR(50),
    @FirstName VARCHAR(50),
    @MiddleName VARCHAR(50),
    @LastName VARCHAR(50),
    @Gender VARCHAR(50),
    @DateOfBirth DATETIME,
    @Email VARCHAR(50),
    @PhoneNumber VARCHAR(50),
    @Address VARCHAR(50),
    @Nationality VARCHAR(50),
    @Branch VARCHAR(50),
    @Salary FLOAT,
    @DateJoined DATETIME,
    @CurrentlyWorking BIT,
    @ECName VARCHAR(50),
    @ECRelation VARCHAR(50),
    @ECPhoneNumber VARCHAR(50),
    @ECEmail VARCHAR(50)
)
AS
INSERT INTO Employee
VALUES
    (@ID, @Department, @FirstName, @MiddleName, @LastName, @Gender, @DateOfBirth, @Email, @PhoneNumber, @Address, @Nationality, @Branch, @Salary, @DateJoined, @CurrentlyWorking, @ECName, @ECRelation, @ECPhoneNumber, @ECEmail, 0)
GO

----------------------------------------------
-- EXAMINATION, LAB AND MEDICATION INSERT PROCEDURES

CREATE PROCEDURE InsertExaminationRecord
    (
    @ID VARCHAR(50) OUTPUT,
    @DateAndTime DATETIME,
    @PatientID VARCHAR(50),
    @PhysicianID VARCHAR(50),
    @Diagnosis VARCHAR(MAX),
    @IsRemovedFromQueue BIT
)
AS
BEGIN
    SELECT @ID = 'EXAM-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM ExaminationRecord
    WHERE ID = @ID)
        SET @ID = 'EXAM-' + (left(replace(newid(),'-',''), 4))

    INSERT INTO ExaminationRecord
    VALUES
        (@ID, @DateAndTime, @PatientID, @PhysicianID, @Diagnosis, @IsRemovedFromQueue);
END
GO

CREATE PROCEDURE InsertLaboratoryRecord
    (
    @ID VARCHAR(50) OUTPUT,
    @ExaminationRecordID VARCHAR(50),
    @DateAndTime DATETIME,
    @PatientID VARCHAR(50),
    @LabPhysicianID VARCHAR(50),
    @TestType VARCHAR(50),
    @Result VARCHAR(MAX),
    @IsRemovedFromQueue BIT
)
AS
BEGIN
    SELECT @ID = 'LAB-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM LaboratoryTestRecord
    WHERE ID = @ID)
        SET @ID = 'LAB-' + (left(replace(newid(),'-',''), 4))

    INSERT INTO LaboratoryTestRecord
    VALUES
        (@ID, @ExaminationRecordID, @DateAndTime, @PatientID, @LabPhysicianID, @TestType, @Result, @IsRemovedFromQueue);
END
GO

CREATE PROCEDURE InsertMedicationRecord
    (
    @ID VARCHAR(50) OUTPUT,
    @ExaminationRecordID VARCHAR(50),
    @Medication VARCHAR(50),
    @AlternativeMedication VARCHAR(50)
)
AS
BEGIN
    SELECT @ID = 'MED-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM MedicationRecord
    WHERE ID = @ID)
        SET @ID = 'MED-' + (left(replace(newid(),'-',''), 4))

    INSERT INTO MedicationRecord
    VALUES
        (@ID, @ExaminationRecordID, @Medication, @AlternativeMedication);
END
GO

-----------------------------------------
-- BILL (AFTER INSERT) TRIGGERS

CREATE TRIGGER RegistrationBill ON Patient
AFTER INSERT
AS
BEGIN
    DECLARE @BillID VARCHAR(50) = 'BILL-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM Bill
    WHERE ID = @BillID)
        SET @BillID = 'BILL-' + (left(replace(newid(),'-',''), 4))

    DECLARE @PatientID VARCHAR(50)
    SELECT @PatientID = INSERTED.ID FROM INSERTED

    INSERT INTO Bill VALUES (@BillID, @PatientID, 'Registration', 125, 0)
END
GO

CREATE TRIGGER ExaminationBill ON ExaminationRecord
AFTER INSERT
AS
BEGIN
    DECLARE @BillID VARCHAR(50) = 'BILL-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM Bill
    WHERE ID = @BillID)
        SET @BillID = 'BILL-' + (left(replace(newid(),'-',''), 4))

    DECLARE @PatientID VARCHAR(50)
    SELECT @PatientID = INSERTED.PatientID FROM INSERTED

    INSERT INTO Bill VALUES (@BillID, @PatientID, 'Out-patient Examination', 450, 0)
END
GO

CREATE TRIGGER LaboratoryTestBill ON LaboratoryTestRecord
AFTER INSERT
AS
BEGIN
    DECLARE @BillID VARCHAR(50) = 'BILL-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM Bill
    WHERE ID = @BillID)
        SET @BillID = 'BILL-' + (left(replace(newid(),'-',''), 4))

    
    DECLARE @PatientID VARCHAR(50), @TestType VARCHAR(50)
    SELECT @PatientID = INSERTED.PatientID, @TestType = INSERTED.TestType FROM INSERTED

    INSERT INTO Bill VALUES (@BillID, @PatientID, 'Laboratory ' + @TestType, 180, 0)
END
GO

CREATE TRIGGER MedicationBill ON MedicationRecord
AFTER INSERT
AS
BEGIN
    DECLARE @BillID VARCHAR(50) = 'BILL-' + left(replace(newid(),'-',''), 4)
    WHILE EXISTS (SELECT *
    FROM Bill
    WHERE ID = @BillID)
        SET @BillID = 'BILL-' + (left(replace(newid(),'-',''), 4))

    -- GET PatientID
    DECLARE @PatientID VARCHAR(50), @ExaminationRecordID VARCHAR(50), @MedicationName VARCHAR(50)
    SELECT @ExaminationRecordID = INSERTED.ExaminationRecordID, @MedicationName = INSERTED.Medication FROM INSERTED
    SELECT @PatientID = PatientID FROM ExaminationRecord WHERE ID = @ExaminationRecordID

    INSERT INTO Bill VALUES (@BillID, @PatientID, 'Medication ' + @MedicationName, 125, 0)
END
GO
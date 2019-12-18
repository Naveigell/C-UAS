USE MASTER

DECLARE @db VARCHAR(30)
SET @db = 'events_olahraga';

IF (DB_ID('events_olahraga') IS NULL)
	BEGIN
		EXEC('CREATE DATABASE ' + @db);
	END
	
IF (DB_ID('events_olahraga') IS NOT NULL)
	BEGIN
		EXEC('USE ' + @db);
	END

CREATE DATABASE events_olahraga;

GO
USE events_olahraga;
GO

IF (DB_ID('events_olahraga') IS NOT NULL)
	BEGIN

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'admin')
			BEGIN
				CREATE TABLE admin(
					id_admin INT IDENTITY(1, 1) PRIMARY KEY,
					email VARCHAR(20) NOT NULL,
					[password] VARCHAR(20) NOT NULL
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'event_olahraga')
			BEGIN
				CREATE TABLE event_olahraga(
					id_event VARCHAR(20) PRIMARY KEY NOT NULL,
					nama_event VARCHAR(15) NOT NULL,
					tanggal_pelaksanaan_event DATETIME NOT NULL,
					tanggal_event_selesai DATETIME NOT NULL,
					tipe_event VARCHAR(30) NOT NULL CHECK(tipe_event IN('perorangan', 'kelompok')) DEFAULT 'perorangan',
					deskripsi VARCHAR(30) NULL,
					event_gender VARCHAR(30) NOT NULL CHECK(event_gender IN('Man', 'Woman', 'Mixed')) DEFAULT 'Mixed',
					status_event TINYINT NOT NULL,
					created_at DATETIME NULL,
					updated_at DATETIME NULL
				);
			END

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'peserta')
			BEGIN
				CREATE TABLE peserta (
					id_peserta VARCHAR(20) PRIMARY KEY NOT NULL,
					id_event VARCHAR(20) NULL,
					nama_peserta VARCHAR(40) NOT NULL,
					nomor_telepon_peserta VARCHAR(15) NOT NULL,
					tipe_peserta VARCHAR(30) NOT NULL CHECK(tipe_peserta IN('Perorangan', 'Kelompok')) DEFAULT 'Perorangan',
					gender VARCHAR(30) NOT NULL CHECK(gender IN('Man', 'Woman')) DEFAULT 'Man',
					created_at DATETIME NULL,
					updated_at DATETIME NULL,
					--FOREIGN KEY(id_event) REFERENCES event_olahraga(id_event) ON DELETE CASCADE ON UPDATE CASCADE
				);
			END

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'field_peserta')
			BEGIN
				CREATE TABLE field_peserta (
					id_field_peserta VARCHAR(20) PRIMARY KEY NOT NULL,
					id_peserta VARCHAR (20) NOT NULL,
					nama_peserta VARCHAR(40) NULL,
					alamat_peserta VARCHAR(30) NOT NULL,
					tanggal_lahir DATETIME NULL,
					created_at DATETIME NULL,
					updated_at DATETIME NULL,
					--FOREIGN KEY(id_event) REFERENCES event_olahraga(id_event) ON DELETE CASCADE ON UPDATE CASCADE
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'schedules')
			BEGIN
				CREATE TABLE schedules(
					
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ranking')
			BEGIN
				CREATE TABLE ranking (
					id_ranking VARCHAR(255),
					id_event VARCHAR(20) NULL,
					id_peserta VARCHAR(20) NULL,
					skor INT NOT NULL
					--FOREIGN KEY(id_events) REFERENCES event_olahraga(id_event) ON DELETE CASCADE ON UPDATE CASCADE,
					--FOREIGN KEY(id_peserta) REFERENCES peserta(id_peserta) ON DELETE CASCADE ON UPDATE CASCADE
				);
			END
	END

ALTER TABLE peserta
  ADD CONSTRAINT peserta_ibfk_1 FOREIGN KEY (id_event) REFERENCES event_olahraga (id_event) ON DELETE NO ACTION ON UPDATE CASCADE

GO
	
ALTER TABLE field_peserta
  ADD CONSTRAINT field_peserta_ibfk_1 FOREIGN KEY (id_peserta) REFERENCES peserta (id_peserta) ON DELETE NO ACTION ON UPDATE CASCADE

GO

ALTER TABLE ranking
  ADD CONSTRAINT ranking_ibfk_1 FOREIGN KEY (id_event) REFERENCES event_olahraga (id_event)

GO

ALTER TABLE ranking
  ADD CONSTRAINT ranking_ibfk_2 FOREIGN KEY (id_peserta) REFERENCES peserta (id_peserta)

DELETE FROM peserta
DELETE FROM ranking
DELETE FROM event_olahraga

  SELECT TOP 1 *, CONVERT (int, SUBSTRING(id_peserta, 6, LEN(id_peserta))) AS SortingID FROM (SELECT * FROM peserta WHERE id_event = 'CTR002') AS a ORDER BY SortingID DESC
 
INSERT INTO event_olahraga (id_event, nama_event, tanggal_pelaksanaan_event, tanggal_event_selesai, tipe_event, event_gender, deskripsi, status_event, created_at, updated_at) VALUES
('AOV001', 'AOV', '2019-12-04 00:00:00', '2019-12-06 00:00:00', 'Kelompok', 'Man', 'Untuk semua umur', 1, NULL, NULL),
('BDM001', 'Badminton', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Man', 'Perlombaan untuk senior', 1, NULL, NULL),
('BDM002', 'Badminton', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Woman', 'Perlombaan untuk senior', 1, NULL, NULL),
('BDM003', 'Badminton', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Kelompok', 'Mixed', 'Perlombaan untuk senior', 1, NULL, NULL),
('BOX001', 'Boxing', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Man', 'Perlombaan untuk senior', 1, NULL, NULL),
('BOX002', 'Boxing', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Woman', 'Perlombaan untuk senior', 1, NULL, NULL),
('CTR001', 'Catur', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Man', 'Perlombaan untuk Junior', 1, NULL, NULL),
('CTR002', 'Catur', '2019-12-16 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Man', 'Perlombaan untuk senior', 1, NULL, NULL),
('CTR003', 'Catur', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Woman', 'Untuk semua umur', 1, NULL, NULL),
('KAR001', 'Karatedo', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Man', 'Untuk semua umur', 1, NULL, NULL),
('KAR002', 'Karatedo', '2019-12-15 00:00:00', '2019-12-18 00:00:00', 'Perorangan', 'Woman', 'Untuk semua umur', 1, NULL, NULL);


INSERT INTO peserta (id_peserta, id_event, nama_peserta, nomor_telepon_peserta, tipe_peserta, gender, created_at, updated_at) VALUES
('AOV1_1', 'AOV001', 'Ardiansyah Farhan Akbari', '081999558922', 'Kelompok', 'Man', NULL, NULL),
('AOV1_2', 'AOV001', 'Falah Gilang', '081999558933', 'Kelompok', 'Man', NULL, NULL),
('AOV1_3', 'AOV001', 'Muliadi Hartawan', '089223456182', 'Kelompok', 'Man', NULL, NULL),
('AOV1_4', 'AOV001', 'Tjia Hartanto', '082123672156', 'Kelompok', 'Man', NULL, NULL),
('AOV1_5', 'AOV001', 'Wiratama Satria Adi', '082123672117', 'Kelompok', 'Man', NULL, NULL),
('BDM5_26', 'BDM001', 'Christie Jonatan', '081273829377', 'Perorangan', 'Man', NULL, NULL),
('BDM5_27', 'BDM001', 'Ginting Anthony Sinisuka', '081283735273', 'Perorangan', 'Man', NULL, NULL),
('BDM5_28', 'BDM001', 'Rivaldy Rinov', '081283735273', 'Perorangan', 'Man', NULL, NULL),
('BDM5_29', 'BDM002', 'Mentari Phita Haningtyas', '081237836728', 'Perorangan', 'Woman', NULL, NULL),
('BDM5_30', 'BDM002', 'Ramadhanti Siti Fadia Silva', '081283728378', 'Perorangan', 'Woman', NULL, NULL),
('BDM5_31', 'BDM002', 'Rahayu Apriyani', '081546829304', 'Perorangan', 'Woman', NULL, NULL),
('BDM5_32', 'BDM003', 'Jordan Praveen', '081546829304', 'Kelompok', 'Man', NULL, NULL),
('BDM5_33', 'BDM003', 'Oktavianti Melati Daeva', '081219382108', 'Kelompok', 'Woman', NULL, NULL),
('BDM5_34', 'BDM003', 'Kholik Firman', '081273837293', 'Kelompok', 'Man', NULL, NULL),
('BDM5_35', 'BDM003', 'Hartawan Ruselli', '081758394829', 'Kelompok', 'Woman', NULL, NULL),
('BOX4_21', 'BOX001', 'Gha Libertus', '081928394829', 'Perorangan', 'Man', NULL, NULL),
('BOX4_22', 'BOX001', 'Papendang Farrand', '081273974858', 'Perorangan', 'Man', NULL, NULL),
('BOX4_23', 'BOX001', 'Simangunsong Grece', '081273849283', 'Perorangan', 'Man', NULL, NULL),
('BOX4_24', 'BOX002', 'Ratu Silpa Lau', '081283947201', 'Perorangan', 'Woman', NULL, NULL),
('BOX4_25', 'BOX002', 'Endang Endang', '081384950384', 'Perorangan', 'Woman', NULL, NULL),
('CTR2_10', 'CTR002', 'Lioe Dede', '081371937429', 'Perorangan', 'Man', NULL, NULL),
('CTR2_11', 'CTR002', 'Megaranto Susanto', '081371253729', 'Perorangan', 'Man', NULL, NULL),
('CTR2_12', 'CTR003', 'Aulia Medina', '082839382918', 'Perorangan', 'Woman', NULL, NULL),
('CTR2_13', 'CTR003', 'Fisabilillah Ummi', '082474829389', 'Perorangan', 'Woman', NULL, NULL),
('CTR2_14', 'CTR003', 'Sihite Chelsie', '082473538389', 'Perorangan', 'Woman', NULL, NULL),
('CTR2_6', 'CTR001', 'Ali Muhammad Lutfi', '082123672177', 'Perorangan', 'Man', NULL, NULL),
('CTR2_7', 'CTR001', 'Priasmoro Novendra', '082147848310', 'Perorangan', 'Man', NULL, NULL),
('CTR2_8', 'CTR001', 'Ervan Mohamad', '082147837284', 'Perorangan', 'Man', NULL, NULL),
('CTR2_9', 'CTR002', 'Cuhendi Sean', '081930828013', 'Perorangan', 'Man', NULL, NULL),
('KAR3_15', 'KAR001', 'Arrosyiid Rifki', '081837483729', 'Perorangan', 'Man', NULL, NULL),
('KAR3_16', 'KAR001', 'Firmansah Sandi', '081389281083', 'Perorangan', 'Man', NULL, NULL),
('KAR3_17', 'KAR001', 'Mardana Andi', '081378493928', 'Perorangan', 'Man', NULL, NULL),
('KAR3_18', 'KAR002', 'Aprilia Krisda', '081839283928', 'Perorangan', 'Woman', NULL, NULL),
('KAR3_19', 'KAR002', 'Winarni Tri', '081273848291', 'Perorangan', 'Woman', NULL, NULL),
('KAR3_20', 'KAR002', 'Sheva Maya', '081379273784', 'Perorangan', 'Woman', NULL, NULL);



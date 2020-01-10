/*USE MASTER

DECLARE @db VARCHAR(30)
SET @db = 'events_olahraga';

IF (DB_ID('events_olahraga') IS NULL)
	BEGIN
		EXEC('CREATE DATABASE ' + @db);
	END
	
IF (DB_ID('events_olahraga') IS NOT NULL)
	BEGIN
		EXEC('USE ' + @db);
	END */

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
					[password] VARCHAR(20)  NOT NULL
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
					gender VARCHAR(30) NOT NULL CHECK(gender IN('Man', 'Woman', 'Mixed')) DEFAULT 'Man',
					created_at DATETIME NULL,
					updated_at DATETIME NULL
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
					field_peserta_gender VARCHAR(30) NOT NULL CHECK(field_peserta_gender IN('Male', 'Female')) DEFAULT 'Man',
					created_at DATETIME NULL,
					updated_at DATETIME NULL
					--FOREIGN KEY(id_event) REFERENCES event_olahraga(id_event) ON DELETE CASCADE ON UPDATE CASCADE
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'schedules')
			BEGIN
				CREATE TABLE schedules(
					id_schedule INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
					id_event VARCHAR(20) NULL,
					rounds INT NOT NULL,
					eliminate TINYINT NOT NULL,
					nama_round VARCHAR(30) NOT NULL
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'score_by_goal')
			BEGIN
				CREATE TABLE score_by_goal (
					id_score_by_goal INT IDENTITY(1, 1) PRIMARY KEY,
					id_scedule INT NULL,
					id_peserta1 VARCHAR(20) NULL,
					id_peserta2 VARCHAR(20) NULL,
					waktu_pelaksanaan DATETIME NULL,
					score_by_goal_score VARCHAR(10) NOT NULL,
					score_by_goal_venue VARCHAR(20) NOT NULL
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'score_by_time')
			BEGIN
				CREATE TABLE score_by_time (
					id_score_by_time INT IDENTITY(1, 1) PRIMARY KEY,
					id_scedule INT NULL,
					id_peserta1 VARCHAR(20) NULL,
					waktu_pelaksanaan DATETIME NULL,
					score_by_time_score VARCHAR(10) NOT NULL,
					score_by_time_venue VARCHAR(20) NOT NULL
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'score_by_individual')
			BEGIN
				CREATE TABLE score_by_individual (
					id_score_by_individual INT IDENTITY(1, 1) PRIMARY KEY,
					id_scedule INT NULL,
					id_peserta1 VARCHAR(20) NULL,
					waktu_pelaksanaan DATETIME NULL,
					score_by_individual_score VARCHAR(10) NOT NULL,
					score_by_individual_venue VARCHAR(20) NOT NULL
				);
			END;

		IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ranking')
			BEGIN
				CREATE TABLE ranking (
					id_ranking INT PRIMARY KEY NOT NULL IDENTITY(1, 1),
					ranking_index VARCHAR(255) NOT NULL,
					id_event VARCHAR(20) NULL,
					id_peserta VARCHAR(20) NULL,
					skor VARCHAR(20) NOT NULL
					--FOREIGN KEY(id_events) REFERENCES event_olahraga(id_event) ON DELETE CASCADE ON UPDATE CASCADE,
					--FOREIGN KEY(id_peserta) REFERENCES peserta(id_peserta) ON DELETE CASCADE ON UPDATE CASCADE
				);
			END
	END
/*
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
  ADD CONSTRAINT ranking_ibfk_2 FOREIGN KEY (id_peserta) REFERENCES peserta (id_peserta) */
/*
DELETE FROM peserta
DELETE FROM field_peserta
DELETE FROM ranking
DELETE FROM event_olahraga

DROP TABLE event_olahraga;

SELECT TOP 1 *, CONVERT (int, SUBSTRING(id_peserta, 6, LEN(id_peserta))) AS SortingID FROM (SELECT * FROM peserta WHERE id_event = 'CTR002') AS a ORDER BY SortingID DESC
 
SELECT score_by_goal.*,
	   peserta1.id_peserta AS id1,
	   peserta2.id_peserta AS id2,
	   peserta1.nama_peserta AS nama1,
	   peserta2.nama_peserta AS nama2
	   FROM score_by_goal
	   INNER JOIN peserta peserta1 ON score_by_goal.id_peserta1 = peserta1.id_peserta
	   INNER JOIN peserta peserta2 ON score_by_goal.id_peserta2 = peserta2.id_peserta
	   WHERE score_by_goal.id_scedule = '4'
	   *//*
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
*/
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------

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


INSERT INTO field_peserta (id_field_peserta, id_peserta, nama_peserta, alamat_peserta, tanggal_lahir, field_peserta_gender, created_at, updated_at) VALUES
('AOV1F_1', 'AOV1_1', 'Hartawan Muliadi', 'Jakarta, Indonesia', '1998-12-19 00:00:00', 'Male', NULL, NULL),
('AOV1F_10', 'AOV1_2', 'Do Thanh Hung', 'Hanoi, Vietnam', '1999-02-28 00:00:00', 'Male', NULL, NULL),
('AOV1F_11', 'AOV1_3', 'Metasit Leelapipatkul', 'Bangkok, Thailand', '1998-04-27 00:00:00', 'Male', NULL, NULL),
('AOV1F_12', 'AOV1_3', 'Sorachat Janechaijitravanit', 'Bangkok, Thailand', '1998-04-07 00:00:00', 'Male', NULL, NULL),
('AOV1F_13', 'AOV1_3', 'Kim Sun Woo', 'Bangkok, Thailand', '1998-02-05 00:00:00', 'Male', NULL, NULL),
('AOV1F_14', 'AOV1_3', 'Shin Chang hoon', 'Bangkok, Thailand', '1999-01-01 00:00:00', 'Male', NULL, NULL),
('AOV1F_15', 'AOV1_3', 'Sorawichaya Mahavanakul', 'Bangkok, Thailand', '1999-11-21 00:00:00', 'Male', NULL, NULL),
('AOV1F_16', 'AOV1_4', 'Honglin Wu', 'Singapore, Singapore', '1999-11-13 00:00:00', 'Male', NULL, NULL),
('AOV1F_17', 'AOV1_4', 'Ce Yon Foo', 'Singapore, Singapore', '1999-10-01 00:00:00', 'Male', NULL, NULL),
('AOV1F_18', 'AOV1_4', 'Jun Jie Wang', 'Singapore, Singapore', '1997-01-30 00:00:00', 'Male', NULL, NULL),
('AOV1F_19', 'AOV1_4', 'Winson Lim', 'Singapore, Singapore', '1998-03-03 00:00:00', 'Male', NULL, NULL),
('AOV1F_2', 'AOV1_1', 'Satria Adi Wiratama', 'Jakarta, Indonesia', '2000-01-09 00:00:00', 'Male', NULL, NULL),
('AOV1F_20', 'AOV1_4', 'Chia Chien Lai', 'Singapore, Singapore', '1998-10-14 00:00:00', 'Male', NULL, NULL),
('AOV1F_21', 'AOV1_5', 'Yim Zhen Hao', 'Kuala Lumpur, Malaysia', '1999-11-01 00:00:00', 'Male', NULL, NULL),
('AOV1F_22', 'AOV1_5', 'Chan Choung Guan', 'Kuala Lumpur, Malaysia', '1999-12-01 00:00:00', 'Male', NULL, NULL),
('AOV1F_23', 'AOV1_5', 'Tan Wei Kun', 'Kuala Lumpur, Malaysia', '1999-02-11 00:00:00', 'Male', NULL, NULL),
('AOV1F_24', 'AOV1_5', 'Chin Wei Song', 'Kuala Lumpur, Malaysia', '2000-06-18 00:00:00', 'Male', NULL, NULL),
('AOV1F_25', 'AOV1_5', 'Po-Han Wu', 'Kuala Lumpur, Malaysia', '1999-08-20 00:00:00', 'Male', NULL, NULL),
('AOV1F_26', 'AOV1_6', 'Jeremiah Querubin', 'Manila, Philiphine', '1997-09-24 00:00:00', 'Male', NULL, NULL),
('AOV1F_27', 'AOV1_6', 'Miguel Banaag', 'Manila, Philiphine', '1999-08-06 00:00:00', 'Male', NULL, NULL),
('AOV1F_28', 'AOV1_6', 'Kevin Kio Dizon', 'Manila, Philiphine', '1999-10-12 00:00:00', 'Male', NULL, NULL),
('AOV1F_29', 'AOV1_6', 'Jevan Delos Santos', 'Manila, Philiphine', '1999-12-02 00:00:00', 'Male', NULL, NULL),
('AOV1F_3', 'AOV1_1', 'Gilang Dwi Falah', 'Jakarta, Indonesia', '1998-02-10 00:00:00', 'Male', NULL, NULL),
('AOV1F_30', 'AOV1_6', 'Lawrence Gatmaitan', 'Manila, Philiphine', '1999-11-12 00:00:00', 'Male', NULL, NULL),
('AOV1F_4', 'AOV1_1', 'Farhan Akbari Ardiansyah', 'Jakarta, Indonesia', '1998-11-07 00:00:00', 'Male', NULL, NULL),
('AOV1F_5', 'AOV1_1', 'Hartanto Lius', 'Jakarta, Indonesia', '1997-08-04 00:00:00', 'Male', NULL, NULL),
('AOV1F_6', 'AOV1_2', 'Nguyen Vu Hoang Dung', 'Hanoi, Vietnam', '1997-03-03 00:00:00', 'Male', NULL, NULL),
('AOV1F_7', 'AOV1_2', 'Nguyen Duy Duc', 'Hanoi, Vietnam', '1997-02-19 00:00:00', 'Male', NULL, NULL),
('AOV1F_8', 'AOV1_2', 'Vuong Trung Khien', 'Hanoi, Vietnam', '1999-02-10 00:00:00', 'Male', NULL, NULL),
('AOV1F_9', 'AOV1_2', 'Huynh Trong Tuan', 'Hanoi, Vietnam', '1999-04-18 00:00:00', 'Male', NULL, NULL),
('BDM1F_31', 'BDM1_26', 'Christie Jonatan', 'Jakarta, Indonesia', '1997-11-12 00:00:00', 'Male', NULL, NULL),
('BDM1F_32', 'BDM1_27', 'Ginting Anthony Sinisuka', 'Jakarta, Indonesia', '1997-09-12 00:00:00', 'Male', NULL, NULL),
('BDM1F_33', 'BDM1_28', 'Rivaldy Rinov', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BDM1F_37', 'BDM1_52', 'Ali Sadikin Aidil Sholeh', 'Jakarta, Indonesia', '1997-11-12 00:00:00', 'Male', NULL, NULL),
('BDM1F_38', 'BDM1_53', 'Avihingsanon Suppanyu', 'Bangkok, Thailand', '1997-11-12 00:00:00', 'Male', NULL, NULL),
('BDM1F_39', 'BDM1_54', 'Cheng Phorrom', 'Bangkok, Thailand', '1997-11-12 00:00:00', 'Male', NULL, NULL),
('BDM2F_34', 'BDM2_29', 'Mentari Phita Haningtyas', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM2F_35', 'BDM2_30', 'Ramadhanti Siti Fadia Silva', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM2F_36', 'BDM2_31', 'Rahayu Apriyani', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM2F_40', 'BDM2_55', 'Amitrapai Savitree', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM2F_41', 'BDM2_56', 'Carlos Maria Bianca Ysabel', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM2F_42', 'BDM2_57', 'Cheah Soniia Su Ya', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM3F_43', 'BDM3_32', 'Tontowi Ahmad', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BDM3F_44', 'BDM3_32', 'Liliyana Natsir', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM3F_45', 'BDM3_33', 'Praveen Jordan', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BDM3F_46', 'BDM3_33', 'Melati Daeva Oktavianti', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM3F_47', 'BDM3_34', 'Hafiz Faizal', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BDM3F_48', 'BDM3_34', 'Gloria Emanuelle Widjaja', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BDM3F_49', 'BDM3_35', 'Ronald Alexander', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BDM3F_50', 'BDM3_35', 'Annisa Saufika', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BOX1F_51', 'BOX1_21', 'Gha Libertus', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BOX1F_52', 'BOX1_22', 'Papendang Farrand', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BOX1F_53', 'BOX1_23', 'Simangunsong Grece', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('BOX2F_54', 'BOX2_24', 'Ratu Silpa Lau', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('BOX2F_55', 'BOX2_25', 'Endang Endang', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR1F_56', 'CTR1_7', 'Priasmoro Novendra', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR1F_57', 'CTR1_8', 'Ervan Mohamad', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR2F_58', 'CTR2_10', 'Lioe Dede', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR2F_59', 'CTR2_11', 'Megaranto Susanto', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR2F_60', 'CTR2_46', 'Laylo Darwin', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR2F_61', 'CTR2_47', 'Kyaw Tun Nay Oo', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR2F_62', 'CTR2_48', 'Khumnorkaew Tupfah', 'Bangkok, Thailand', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('CTR2F_63', 'CTR3_12', 'Aulia Medina', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR2F_64', 'CTR3_13', 'Fisabilillah Ummi', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR2F_65', 'CTR3_14', 'Sihite Chelsie', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR2F_66', 'CTR3_49', 'Atikankhotchasee Manunthon', 'Bangkok, Thailand', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR2F_67', 'CTR3_50', 'Azman Hisham Nur Nabila', 'Kuala Lumpur, Malaysia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR2F_68', 'CTR3_51', 'Azman Hisham Nur Najiha', 'Kuala Lumpur, Malaysia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('CTR2F_69', 'CTR2_9', 'Cuhendi Sean', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR1F_70', 'KAR1_15', 'Arrosyiid Rifki', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR1F_71', 'KAR1_16', 'Firmansah Sandi', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR1F_72', 'KAR1_17', 'Mardana Andi', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR1F_73', 'KAR1_36', 'Hutapea Tebing', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR1F_74', 'KAR1_37', 'Nababan Dian', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR1F_75', 'KAR1_38', 'Saputra Ari', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Male', NULL, NULL),
('KAR2F_76', 'KAR2_18', 'Aprilia Krisda', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('KAR2F_77', 'KAR2_19', 'Winarni Tri', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('KAR2F_78', 'KAR2_20', 'Sheva Maya', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('KAR2F_79', 'KAR2_39', 'Zefanya Ceyco', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('KAR2F_80', 'KAR2_40', 'Hanandyta Emilia', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL),
('KAR2F_81', 'KAR2_41', 'Sanistyarani Cok Istri', 'Jakarta, Indonesia', '1998-09-02 00:00:00', 'Female', NULL, NULL);


INSERT INTO peserta (id_peserta, id_event, nama_peserta, nomor_telepon_peserta, tipe_peserta, gender, created_at, updated_at) VALUES
('AOV1_1', 'AOV001', 'Evos Esport', '081999558922', 'Kelompok', 'Man', NULL, NULL),
('AOV1_2', 'AOV001', 'Mocha ZD Esport', '081999558933', 'Kelompok', 'Man', NULL, NULL),
('AOV1_3', 'AOV001', 'Toyota Diamond Cobra', '089223456182', 'Kelompok', 'Man', NULL, NULL),
('AOV1_4', 'AOV001', 'Resurgence', '082123672156', 'Kelompok', 'Man', NULL, NULL),
('AOV1_5', 'AOV001', 'M8Hexa', '082123672117', 'Kelompok', 'Man', NULL, NULL),
('AOV1_6', 'AOV001', 'Liyab Esport', '082123672177', 'Kelompok', 'Man', NULL, NULL),
('BDM1_26', 'BDM001', 'Christie Jonatan', '081273829377', 'Perorangan', 'Man', NULL, NULL),
('BDM1_27', 'BDM001', 'Ginting Anthony Sinisuka', '081283735273', 'Perorangan', 'Man', NULL, NULL),
('BDM1_28', 'BDM001', 'Rivaldy Rinov', '081283735273', 'Perorangan', 'Man', NULL, NULL),
('BDM1_52', 'BDM001', 'Ali Sadikin Aidil Sholeh', '081738293647', 'Perorangan', 'Man', NULL, NULL),
('BDM1_53', 'BDM001', 'Avihingsanon Suppanyu', '081728394657', 'Perorangan', 'Man', NULL, NULL),
('BDM1_54', 'BDM001', 'Cheng Phorrom', '081728394756', 'Perorangan', 'Man', NULL, NULL),
('BDM2_29', 'BDM002', 'Mentari Phita Haningtyas', '081237836728', 'Perorangan', 'Woman', NULL, NULL),
('BDM2_30', 'BDM002', 'Ramadhanti Siti Fadia Silva', '081283728378', 'Perorangan', 'Woman', NULL, NULL),
('BDM2_31', 'BDM002', 'Rahayu Apriyani', '081546829304', 'Perorangan', 'Woman', NULL, NULL),
('BDM2_55', 'BDM002', 'Amitrapai Savitree', '081628394758', 'Perorangan', 'Woman', NULL, NULL),
('BDM2_56', 'BDM002', 'Carlos Maria Bianca Ysabel', '081829374658', 'Perorangan', 'Woman', NULL, NULL),
('BDM2_57', 'BDM002', 'Cheah Soniia Su Ya', '081829384756', 'Perorangan', 'Woman', NULL, NULL),
('BDM3_32', 'BDM003', 'Indonesia 1', '081546829304', 'Kelompok', 'Mixed', NULL, NULL),
('BDM3_33', 'BDM003', 'Indonesia 2', '081219382108', 'Kelompok', 'Mixed', NULL, NULL),
('BDM3_34', 'BDM003', 'Indonesia 3', '081273837293', 'Kelompok', 'Mixed', NULL, NULL),
('BDM3_35', 'BDM003', 'Indonesia 4', '081758394829', 'Kelompok', 'Mixed', NULL, NULL),
('BOX1_21', 'BOX001', 'Gha Libertus', '081928394829', 'Perorangan', 'Man', NULL, NULL),
('BOX1_22', 'BOX001', 'Papendang Farrand', '081273974858', 'Perorangan', 'Man', NULL, NULL),
('BOX1_23', 'BOX001', 'Simangunsong Grece', '081273849283', 'Perorangan', 'Man', NULL, NULL),
('BOX2_24', 'BOX002', 'Ratu Silpa Lau', '081283947201', 'Perorangan', 'Woman', NULL, NULL),
('BOX2_25', 'BOX002', 'Endang Endang', '081384950384', 'Perorangan', 'Woman', NULL, NULL),
('CTR1_42', 'CTR001', 'Arunnuntapanich Tinnakrit', '082147646577', 'Perorangan', 'Man', NULL, NULL),
('CTR1_43', 'CTR001', 'Bersamina Paulo', '082354768594', 'Perorangan', 'Man', NULL, NULL),
('CTR1_44', 'CTR001', 'Kananub Warot', '082738544374', 'Perorangan', 'Man', NULL, NULL),
('CTR1_45', 'CTR001', 'Le Tuan Minh', '082638495634', 'Perorangan', 'Man', NULL, NULL),
('CTR1_7', 'CTR001', 'Priasmoro Novendra', '082147848310', 'Perorangan', 'Man', NULL, NULL),
('CTR1_8', 'CTR001', 'Ervan Mohamad', '082147837284', 'Perorangan', 'Man', NULL, NULL),
('CTR2_10', 'CTR002', 'Lioe Dede', '081371937429', 'Perorangan', 'Man', NULL, NULL),
('CTR2_11', 'CTR002', 'Megaranto Susanto', '081371253729', 'Perorangan', 'Man', NULL, NULL),
('CTR2_46', 'CTR002', 'Laylo Darwin', '081637483927', 'Perorangan', 'Man', NULL, NULL),
('CTR2_47', 'CTR002', 'Kyaw Tun Nay Oo', '081637483927', 'Perorangan', 'Man', NULL, NULL),
('CTR2_48', 'CTR002', 'Khumnorkaew Tupfah', '081827465822', 'Perorangan', 'Man', NULL, NULL),
('CTR2_9', 'CTR002', 'Cuhendi Sean', '081930828013', 'Perorangan', 'Man', NULL, NULL),
('CTR3_12', 'CTR003', 'Aulia Medina', '082839382918', 'Perorangan', 'Woman', NULL, NULL),
('CTR3_13', 'CTR003', 'Fisabilillah Ummi', '082474829389', 'Perorangan', 'Woman', NULL, NULL),
('CTR3_14', 'CTR003', 'Sihite Chelsie', '082473538389', 'Perorangan', 'Woman', NULL, NULL),
('CTR3_49', 'CTR003', 'Atikankhotchasee Manunthon', '082738291745', 'Perorangan', 'Woman', NULL, NULL),
('CTR3_50', 'CTR003', 'Azman Hisham Nur Nabila', '082748392746', 'Perorangan', 'Woman', NULL, NULL),
('CTR3_51', 'CTR003', 'Azman Hisham Nur Najiha', '082643748272', 'Perorangan', 'Woman', NULL, NULL),
('KAR1_15', 'KAR001', 'Arrosyiid Rifki', '081837483729', 'Perorangan', 'Man', NULL, NULL),
('KAR1_16', 'KAR001', 'Firmansah Sandi', '081389281083', 'Perorangan', 'Man', NULL, NULL),
('KAR1_17', 'KAR001', 'Mardana Andi', '081378493928', 'Perorangan', 'Man', NULL, NULL),
('KAR1_36', 'KAR001', 'Hutapea Tebing', '081074629174', 'Perorangan', 'Man', NULL, NULL),
('KAR1_37', 'KAR001', 'Nababan Dian', '081074629174', 'Perorangan', 'Man', NULL, NULL),
('KAR1_38', 'KAR001', 'Saputra Ari', '081074826492', 'Perorangan', 'Man', NULL, NULL),
('KAR2_18', 'KAR002', 'Aprilia Krisda', '081839283928', 'Perorangan', 'Woman', NULL, NULL),
('KAR2_19', 'KAR002', 'Winarni Tri', '081273848291', 'Perorangan', 'Woman', NULL, NULL),
('KAR2_20', 'KAR002', 'Sheva Maya', '081379273784', 'Perorangan', 'Woman', NULL, NULL),
('KAR2_39', 'KAR002', 'Zefanya Ceyco', '081379273739', 'Perorangan', 'Woman', NULL, NULL),
('KAR2_40', 'KAR002', 'Hanandyta Emilia', '083647274916', 'Perorangan', 'Woman', NULL, NULL),
('KAR2_41', 'KAR002', 'Sanistyarani Cok Istri', '083647276383', 'Perorangan', 'Woman', NULL, NULL);


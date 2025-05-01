USE [AppsdevEnrollment]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentFile]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[StudentFile](
        [STFSTUDID] [bigint] NOT NULL,
        [STFSTUDLNAME] [nvarchar](15) NOT NULL,
        [STFSTUDFNAME] [nvarchar](15) NOT NULL,
        [STFSTUDMNAME] [nvarchar](15) NULL,
        [STFSTUDCOURSE] [nvarchar](10) NOT NULL,
        [STFSTUDYEAR] [int] NOT NULL,
        [STFSTUDREMARKS] [nvarchar](15) NOT NULL,
        [STFSTUDSTATUS] [nvarchar](8) NOT NULL,
        CONSTRAINT [PK_StudentFile] PRIMARY KEY CLUSTERED ([STFSTUDID] ASC)
    )
END
GO

-- Add check constraints for enums
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_StudentFile_Remarks]'))
BEGIN
    ALTER TABLE [dbo].[StudentFile]
    ADD CONSTRAINT [CK_StudentFile_Remarks] 
    CHECK ([STFSTUDREMARKS] IN ('Shiftee', 'Transferee', 'New', 'Old', 'CrossEnrollee', 'Returnee'))
END
GO

IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_StudentFile_Status]'))
BEGIN
    ALTER TABLE [dbo].[StudentFile]
    ADD CONSTRAINT [CK_StudentFile_Status] 
    CHECK ([STFSTUDSTATUS] IN ('Active', 'Inactive'))
END
GO

-- Insert sample data
IF NOT EXISTS (SELECT * FROM [dbo].[StudentFile])
BEGIN
    INSERT INTO [dbo].[StudentFile] 
    ([STFSTUDID], [STFSTUDLNAME], [STFSTUDFNAME], [STFSTUDMNAME], [STFSTUDCOURSE], [STFSTUDYEAR], [STFSTUDREMARKS], [STFSTUDSTATUS])
    VALUES
    (20240001, 'Smith', 'John', 'Michael', 'BSCS', 1, 'New', 'Active'),
    (20240002, 'Johnson', 'Emily', 'Rose', 'BSIT', 2, 'Old', 'Active'),
    (20240003, 'Williams', 'David', 'James', 'BSCS', 3, 'Transferee', 'Active')
END
GO 
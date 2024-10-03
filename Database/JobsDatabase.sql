CREATE TABLE Jobs (
  JobID INT IDENTITY(1,1) PRIMARY KEY,
  JobType VARCHAR(50) NOT NULL,
  JobName VARCHAR(100) NOT NULL,
  JobFrequency VARCHAR(50) NOT NULL,
);

CREATE TABLE JobTransactions (
  JobTransactionID INT IDENTITY(1,1) PRIMARY KEY,
  Job_Status VARCHAR(50) NOT NULL,
  LastRunSchedule DATETIME NOT NULL,
  CONSTRAINT FK_JobTransactionID FOREIGN KEY (JobTransactionID) REFERENCES Jobs(JobID)
);

CREATE TABLE JobOwners (
  JobOwnerID INT IDENTITY(1,1) PRIMARY KEY,
  JobOwnerName VARCHAR(50) NOT NULL
  CONSTRAINT FK_JobOwnerID FOREIGN KEY (JobOwnerID) REFERENCES Jobs(JobID)
);

CREATE TABLE JobDependencies (
  JobDependencyID INT IDENTITY(1,1) PRIMARY KEY, --Each Dependency has a column ID and is set to auto increment     
  DependentJobID INT, --ie Job ID in the main table                       
  Dependency VARCHAR(100),                       
  DependencyDirection INT CHECK (DependencyDirection in (1, -1)), 
  /*1 or -1 to indicate u*/
  /*the direction of dependency, 
  whether it is upstream or downstream */ 

  CONSTRAINT FK_DependentJobID FOREIGN KEY (DependentJobID) REFERENCES Jobs(JobID),
  --CONSTRAINT FK_JobDependencyID FOREIGN KEY (JobDependencyID) REFERENCES Jobs(JobID)
);
GO
CREATE VIEW JobsData AS 
SELECT 
    j.JobType,
    j.JobName,
    j.JobFrequency,
    jt.LastRunSchedule,
    jo.JobOwner,
    jt.Job_Status AS Status,
    upstream.Dependency AS JobDependencyUpstream,
    downstream.Dependency AS JobDependencyDownstream
FROM 
    Jobs j
LEFT JOIN
	JobTransactions jt ON j.JobID = jt.JobTransactionID 
LEFT JOIN
    JobOwners jo ON j.JobID = jo.JobOwnerID
LEFT JOIN
    JobDependencies upstream ON j.JobID = upstream.DependentJobID AND
    upstream.DependencyDirection = 1
LEFT JOIN
    JobDependencies downstream ON j.JobID = downstream.DependentJobID AND
    downstream.DependencyDirection = -1
GO

INSERT INTO Jobs (JobType, JobName, JobFrequency)
VALUES 
('Type1', 'Job1', 'Daily'),
('Type2', 'Job2', 'Weekly');

INSERT INTO JobTransactions (Job_Status, LastRunSchedule)
VALUES 
('Completed', '2024-10-01 10:00:23'),
('Failed', '2024-10-01 11:00:26');


INSERT INTO JobOwners (JobOwner)
VALUES 
('Owner1'),
('Owner2');

INSERT INTO JobDependencies (DependentJobID, Dependency, DependencyDirection)
VALUES 
(1, 'Dependency1', 1),
(2, 'Dependency2', -1);

SELECT * FROM JobsData;

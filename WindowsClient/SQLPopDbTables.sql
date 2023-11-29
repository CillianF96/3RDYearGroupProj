USE [ProductTracker]
GO

INSERT INTO [dbo].[Users]
           ([Name]
           ,[Password]
           ,[UserType]
           ,[UserID])
     VALUES
           ('m','m','Manager',1),('s','s','Sales',2),('p','p','Production',3)
GO


INSERT INTO [dbo].[Orders]
           ([OrderCode]
           ,[AgentCode]
           ,[CustomerCode]
           ,[Complete]
		   ,[OrderDate])
     VALUES
           (1001,15,87,0,'10-apr-2014'),(1002,22,162,1,'20-apr-2014'),(1003,15,45,0,'30-apr-2014')
GO

INSERT INTO [dbo].[ProductLines]
           ([ProductLineCode]
           ,[OrderCode]
           ,[ProductCode]
           ,[QtyOrdered]
           ,[QtyPrepared]
           ,[Complete])
     VALUES
           (1,1001,'PT223',100,0,0),(1,1002,'PT105',250,250,1),(2,1002,'PT111',50,50,1),(1,1003,'PN104',80,40,0),(2,1003,'PN125',50,50,1),(3,1003,'PT223',100,0,0)
		  
GO

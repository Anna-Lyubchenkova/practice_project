USE [practice_cosmetics_shop]
GO

Create View [dbo].[Staff_view]
	As
		Select StaffID, Surname, Name, Age, Position, Post, Salary FROM Staff,Post
			Where Staff.Position = Post.PostId;
GO



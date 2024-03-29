USE [master]
GO
/****** Object:  Database [practice_cosmetics_shop]    Script Date: 12.07.2019 21:34:34 ******/
CREATE DATABASE [practice_cosmetics_shop]
GO
ALTER DATABASE [practice_cosmetics_shop] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [practice_cosmetics_shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [practice_cosmetics_shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [practice_cosmetics_shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [practice_cosmetics_shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [practice_cosmetics_shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [practice_cosmetics_shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [practice_cosmetics_shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [practice_cosmetics_shop] SET  MULTI_USER 
GO
ALTER DATABASE [practice_cosmetics_shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [practice_cosmetics_shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [practice_cosmetics_shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [practice_cosmetics_shop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [practice_cosmetics_shop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [practice_cosmetics_shop] SET QUERY_STORE = OFF
GO
USE [practice_cosmetics_shop]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Surname] [varchar](25) NOT NULL,
	[Phone] [varchar](10) NULL,
	[E-mail] [varchar](25) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Clients_view]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Clients_view]
	As 
		Select * FROM Clients;
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NOT NULL,
	[Surname] [varchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Position] [int] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Post] [nchar](15) NOT NULL,
	[Salary] [money] NULL,
	[Nalog] [int] NULL,
	[Clean Salary]  AS ([Salary]-([Salary]*[Nalog])/(100)),
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Staff_view]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Staff_view]
	As
		Select StaffID, Surname, Name, Age, Position, Post, Salary FROM Staff,Post
			Where Staff.Position = Post.PostId;
GO
/****** Object:  Table [dbo].[Items]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Article] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [nchar](20) NOT NULL,
	[Cost] [money] NOT NULL,
	[Num_inShop] [int] NOT NULL,
	[Reserved] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Product_List]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Product_List]
AS
SELECT        Article, Item_Name, Cost AS [cost, RUB], Num_inShop
FROM            dbo.Items
GO
/****** Object:  Table [dbo].[ClientOrder]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientOrder](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[Client] [int] NOT NULL,
	[Order Date] [date] NOT NULL,
	[SellerID] [int] NOT NULL,
	[Status] [varchar](5) NULL,
 CONSTRAINT [PK_ClientOrder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Clients_Orders_all]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Clients_Orders_all]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = ANY (Select Status FROM ClientOrder);

GO
/****** Object:  View [dbo].[Clients_Orders_new]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Clients_Orders_new]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = 'New';

GO
/****** Object:  View [dbo].[Clients_Orders_wait]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Clients_Orders_wait]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = 'Wait';

GO
/****** Object:  View [dbo].[Clients_Orders_ready]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Clients_Orders_ready]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = 'Ready';

GO
/****** Object:  View [dbo].[Clients_Orders_sold]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Clients_Orders_sold]
	As
		Select OrderID, ClientID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where ClientOrder.Status = 'Sold';
GO
/****** Object:  Table [dbo].[Basket]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basket](
	[ItemID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[OrderID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Basket_view]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Basket_view]
	As
		Select * FROM Basket
GO
/****** Object:  Table [dbo].[ItemListToOrder]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemListToOrder](
	[ItemID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[Status] [varchar](5) NULL,
 CONSTRAINT [PK_ItemListToOrder] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ordered_Items]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[Ordered_Items]
	As
		Select OrderID, ItemID, Amount, Num_inShop, Reserved, ItemListToOrder.Status
			From Items JOIN ItemListToOrder ON Items.Article = ItemListToOrder.ItemID
GO
/****** Object:  View [dbo].[Active_clients]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Active_clients]
AS
SELECT        dbo.Clients.Name, dbo.Clients.Surname, COUNT(dbo.ClientOrder.OrderID) AS 'Orders'
FROM            dbo.Clients INNER JOIN
                         dbo.ClientOrder ON dbo.Clients.ClientID = dbo.ClientOrder.Client
GROUP BY dbo.Clients.Name, dbo.Clients.Surname
GO
ALTER TABLE [dbo].[ClientOrder] ADD  CONSTRAINT [DF_ClientOrder_Status]  DEFAULT (N'New') FOR [Status]
GO
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_Phone]  DEFAULT ('-') FOR [Phone]
GO
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_E-mail]  DEFAULT ('-') FOR [E-mail]
GO
ALTER TABLE [dbo].[ItemListToOrder] ADD  CONSTRAINT [DF_ItemListToOrder_Status]  DEFAULT (N'New') FOR [Status]
GO
ALTER TABLE [dbo].[Items] ADD  CONSTRAINT [DF_Items_Num_inShop]  DEFAULT ((0)) FOR [Num_inShop]
GO
ALTER TABLE [dbo].[Items] ADD  CONSTRAINT [DF_Items_Reserved]  DEFAULT ((0)) FOR [Reserved]
GO
ALTER TABLE [dbo].[ClientOrder]  WITH CHECK ADD  CONSTRAINT [FK_ClientOrder_Clients] FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([ClientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientOrder] CHECK CONSTRAINT [FK_ClientOrder_Clients]
GO
ALTER TABLE [dbo].[ClientOrder]  WITH CHECK ADD  CONSTRAINT [FK_ClientOrder_Staff] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[ClientOrder] CHECK CONSTRAINT [FK_ClientOrder_Staff]
GO
ALTER TABLE [dbo].[ItemListToOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemListToOrder_ClientOrder] FOREIGN KEY([OrderID])
REFERENCES [dbo].[ClientOrder] ([OrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemListToOrder] CHECK CONSTRAINT [FK_ItemListToOrder_ClientOrder]
GO
ALTER TABLE [dbo].[ItemListToOrder]  WITH CHECK ADD  CONSTRAINT [FK_ItemListToOrder_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([Article])
GO
ALTER TABLE [dbo].[ItemListToOrder] CHECK CONSTRAINT [FK_ItemListToOrder_Items]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Post] FOREIGN KEY([Position])
REFERENCES [dbo].[Post] ([PostId])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Post]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [inShop] CHECK  (([Num_inShop]>=(0)))
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [inShop]
GO
/****** Object:  StoredProcedure [dbo].[Check_Order]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Check_Order] (@orderid as int, @sort as varchar(10))
	AS
		/*Запрос на вывод товаров в заказе по номеру заказа. Входное данное - номер заказа*/
		if (@sort = 'Item_Name')
		Select Item_Name, Amount, 
			Items.Cost * Amount as 'Summa', ItemListToOrder.Status
				FROM ClientOrder Join ItemListToOrder on ClientOrder.OrderID = ItemListToOrder.OrderID 
				JOIN Items ON Items.Article = ItemListToOrder.ItemID
						Where ClientOrder.OrderID = @orderid
						Order By Item_Name;
		if (@sort = 'Summa')
			Select Item_Name, Amount, 
			Items.Cost * Amount as 'Summa', ItemListToOrder.Status
				FROM ClientOrder Join ItemListToOrder on ClientOrder.OrderID = ItemListToOrder.OrderID 
				JOIN Items ON Items.Article = ItemListToOrder.ItemID
						Where ClientOrder.OrderID = @orderid
						Order By 'Summa';
		if (@sort = 'Status')
			Select Item_Name, Amount, 
			Items.Cost * Amount as 'Summa', ItemListToOrder.Status
				FROM ClientOrder Join ItemListToOrder on ClientOrder.OrderID = ItemListToOrder.OrderID 
				JOIN Items ON Items.Article = ItemListToOrder.ItemID 
						Where ClientOrder.OrderID = @orderid
						Order By ItemListToOrder.Status;
GO
/****** Object:  StoredProcedure [dbo].[Product_in_Range]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Product_in_Range] (@a_range as int, @b_range as int)
	AS
		/*запрос о выдаче списка товаров, лежащих в диапазоне цен, можно добавить товары 
		только по акции через параметр. Входное данное - границы диапазона.*/
	Select Item_Name, Cost , Num_inShop as 'Available'
		FROM Items 
				Where CONVERT(int,Cost) Between @a_range And @b_range
					Order By Cost,Item_Name;
GO
/****** Object:  StoredProcedure [dbo].[Product_Info]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Product_Info] (@product_n as int)
	As
		/*запрос на получение информации по товару от продавца. наименование - входное данное*/
		Select Item_Name, Cost as 'cost, RUB', Num_inShop, Reserved 
			FROM Items
				Where Article=@product_n;
GO
/****** Object:  StoredProcedure [dbo].[Product_Info_Client]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Product_Info_Client] (@product_n as nchar(20))
	As
		/*запрос на информацию о товаре от покупателя. Входное данное - наименование*/
	Select Item_Name, Cost as 'cost, RUB',Num_inShop 
		FROM Items 
			Where Item_name=@product_n;

GO
/****** Object:  StoredProcedure [dbo].[Reserved_Items]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Reserved_Items] 
	As
		/*Запрос на вывод товаров, которые в данный момент в резерве*/
		Select Item_Name, Items.Reserved FROM Items
			Where Reserved > 0;

GO
/****** Object:  StoredProcedure [dbo].[Seller_sold_order]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Seller_sold_order] (@order_num as int)
	AS
		UPDATE Ordered_Items SET Status = 'Sold'
			Where Ordered_Items.OrderID = @order_num
		UPDATE ClientOrder SET Status = 'Sold'
			Where ClientOrder.OrderID = @order_num
GO
/****** Object:  StoredProcedure [dbo].[Seller_upd_order]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Seller_upd_order] (@order_num as int)
	AS
		UPDATE ClientOrder SET Status = 'Wait'
			Where ClientOrder.OrderID = @order_num
		UPDATE Ordered_Items SET Reserved = Reserved + Amount
			Where Amount > Num_inShop AND Status = 'New' AND OrderID = @order_num
		UPDATE Ordered_Items SET Status = 'Wait'
			Where Amount > Num_inShop AND Status IN ('New','Wait') AND OrderID = @order_num
		UPDATE Ordered_Items Set Status = 'PreR'
			Where Amount <= Num_inShop AND Status IN ('New','Wait') AND OrderID = @order_num
		UPDATE Ordered_Items SET Num_inShop = Num_inShop - Amount
			Where Status = 'PreR' AND OrderID = @order_num
		UPDATE Ordered_Items SET Status = 'Ready'
			Where Status = 'PreR' AND OrderID = @order_num
GO
/****** Object:  StoredProcedure [dbo].[View_Orders]    Script Date: 29.06.2019 21:34:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[View_Orders] (@client as int, @mode as int = 0)
	As
		/*Запрос на вывод заказов по данному клиенту,комбинации по фильтру в кач. переменной
			Входное данное - номер клиента*/
	If (@mode = 0) /*вывести все заказы*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
				JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
					Where Client = @client AND ClientOrder.Status = ANY (Select Status FROM ClientOrder);
	IF (@mode = 1) /*только созданные заказы*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
			JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
				Where Client = @client AND ClientOrder.Status = 'New'
	IF (@mode = 2) /*только заказы в резерве.При том полностью reserved и частично reserved заказы - WAIT*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder,Clients, Staff
				Where Clients.ClientID = ClientOrder.Client AND
					ClientOrder.SellerID = Staff.StaffID AND Client = @client AND
					ClientOrder.Status = 'Wait'
	IF (@mode = 4) /*только завершенные заказы*/
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder,Clients, Staff
				Where Clients.ClientID = ClientOrder.Client AND
					ClientOrder.SellerID = Staff.StaffID AND Client = @client AND
					ClientOrder.Status = 'Sold'
	IF (@mode = 3) /*резерв и только созданные заказы */ 
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder JOIN Clients ON Clients.ClientID = ClientOrder.Client
			JOIN Staff ON ClientOrder.SellerID = Staff.StaffID
				Where Client = @client
		EXCEPT 
		Select OrderID, Clients.Surname, Clients.Name, [Order Date], Staff.Surname as 'Staff', Status 
			FROM ClientOrder,Clients, Staff
				Where Clients.ClientID = ClientOrder.Client AND
				ClientOrder.SellerID = Staff.StaffID AND
				ClientOrder.Status IN ('Sold');

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Не может быть <0 в магазине' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'CONSTRAINT',@level2name=N'inShop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clients"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 162
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ClientOrder"
            Begin Extent = 
               Top = 6
               Left = 266
               Bottom = 165
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Active_clients'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Active_clients'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Items"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Product_List'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Product_List'
GO
USE [master]
GO
ALTER DATABASE [practice_cosmetics_shop] SET  READ_WRITE 
GO

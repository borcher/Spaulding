USE [Spaulding]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 06/11/2022 23:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [nvarchar](255) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[ShipDate] [datetime] NULL,
	[ShipMode] [nvarchar](255) NULL,
	[CustomerId] [nvarchar](255) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[Segment] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[State] [nvarchar](255) NULL,
	[Postal Code] [float] NULL,
	[Region] [nvarchar](255) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrdersReturns]    Script Date: 06/11/2022 23:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersReturns](
	[OrderId] [nvarchar](255) NOT NULL,
	[Comments] [nvarchar](255) NULL,
 CONSTRAINT [PK_OrdersReturns] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 06/11/2022 23:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [nvarchar](255) NOT NULL,
	[ProductId] [nvarchar](255) NOT NULL,
	[Category] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[ProductName] [nvarchar](255) NULL,
	[Sales] [float] NOT NULL,
	[Quantity] [float] NULL,
	[Discount] [float] NULL,
	[Profit] [float] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[OrdersReturns]  WITH CHECK ADD  CONSTRAINT [FK_OrdersReturns_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrdersReturns] CHECK CONSTRAINT [FK_OrdersReturns_Orders]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Orders]
GO

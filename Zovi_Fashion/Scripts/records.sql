SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (1, N'ADIDAS Originals')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (2, N'French Connection')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (3, N'GAP')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (4, N'Louis Philippe')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (5, N'Tommy Hilfiger')
GO
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (6, N'Van Heusen')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (1, N'Men Black SST TT Sporty Jackets', N'60% Polyester - 40% Cotton', N'December 2020', N'Black solid sporty jacket,has a stand collar,Long sleeves with ribbed cuffs,Soft feel,Full zip; 2 Front zip pockets; Ribbed hem', N'Black', N'Regular', N'Long Sleeves', N'Sports', N'Solid', N'Medium', N'Stand Collar', N'Machine-wash', N'ADI SPORTS (INDIA) PVT. LTD.', N'$99', N'.jpg', 1)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (2, N'Adidas Originals Men Navy Blue Firebird Track Solid Sporty Jacket', N'Polyester', N'January 2021', N'Mock collar, Regular fit is not tight and not loose, the perfect in-between fit, Long sleeves with ribbed cuffs, Zip pockets; Full zip; Ribbed hem, A trefoil logo, 3-Stripes down the sleeves', N'Navy Blue', N'Regular', N'Long Sleeves', N'Sports', N'Solid', N'Large', N'Mock Collar', N'Machine-wash', N'ADI SPORTS (INDIA) PVT. LTD.', N'$100', N'.jpg', 1)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (3, N'Men White & Blue Slim Fit Checked Formal Shirt', N'Cotton', N'December 2020', N'White and Blue checked formal shirt, has a spread collar, long sleeves, button placket, curved hem, and 1 patch pocket', N'White', N'Slim Fit', N'Long Sleeves', N'Formal', N'Checks', N'Medium', N'Spread Collar', N'Machine-wash', N'RetailNet', N'$39', N'.jpg', 4)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (4, N'Men Green & White Slim Fit Checked Formal Shirt', N'95% Cotton and 5% Elastane', N'November 2020', N'Green and White checked formal shirt, has a spread collar, long sleeves, button placket, and curved hem', N'White', N'Slim Fit', N'Long Sleeves', N'Formal', N'Checks', N'Large', N'Spread Collar', N'Machine-wash', N'RetailNet', N'$49', N'.jpg', 4)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (5, N'Men Charcoal black & Blue Slim Fit Checked Formal Trousers', N'60% polyester, 23% viscose, 15% wool and 2% spandex', N'Jabuary 2021', N'Charcoal black and blue checked mid-rise formal trousers, has a button and zip closure, and 4 pockets', N'Charcoal black', N'Slim Fit', N'NA', N'Formal', N'Checked', N'32', N'NA',N'Machine-wash' ,N'RetailNet', N'$57', N'.jpg', 4)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (6, N'Men black & White Slim Fit Striped Formal Trousers', N'64% polyester, 34% viscose rayon, 2% elastane', N'October 2020', N'black and White striped low-rise trousers, button closure, and 5 pockets.', N'black', N'Slim Fit', N'NA', N'Formal', N'Striped', N'34', N'NA', N'Machine-wash', N'RetailNet', N'$99', N'.jpg', 4)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (7, N'Men black Solid Sweatshirt', N'97% cotton, 3% elastane', N'January 2021', N'black solid sweatshirt, has a hood, two pockets, long sleeves, straight hem', N'black', N'Regular', N'Long Sleeves', N'Casual', N'Solid', N'Large', N'Hood', N'Machine-wash', N'Flashtech Retail', N'$55', N'.jpg', 5)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (8, N'Men Green & Blue Checked Regular Fit Casual Shirt', N' 100% Cotton', N'October 2020', N'Green and blue checked casual shirt, has a button-down collar, long sleeves, button placket, and curved hem', N'Green', N'Regular', N'Long Sleeves', N'Casual', N'Checked', N'42', N'Button-Down Collar', N'Machine-wash', N'Flashtech Retail', N'$85', N'.jpg', 5)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (9, N'Men Red Printed Pullover Sweater', N'Cotton', N'January 2021', N'Red printed pullover sweater, has a round neck, long sleeves, and straight hem', N'Red', N'Regular', N'Long Sleeves', N'Casual', N'Printed', N'Medium', N'Round', N'Machine-wash', N'ARVIND LIFESTYLE BRANDS LTD.', N'$39', N'.jpg', 3)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (10, N'Men Navy Blue Checkered Blazer', N'65% Polyester and 35% Viscose', N'August 2020', N'Navy Blue checkered single-breasted blazer for men with notched lapel, button closure, three front pockets and long sleeves', N'Navy Blue', N'Slim Fit', N'Long Sleeves', N'Formal', N'Checked', N'Large', N'Notched Lapel', N'Dry-clean', N'RetailNet', N'$67', N'.jpg', 6)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Fabric], [ManufacturingYear], [Description], [Color], [Fit], [SleveLength], [Occasion], [PatternType], [Size], [Neck], [WashCare], [SoldBy], [Price], [Extension], [BrandID]) VALUES (11, N'Men Navy Blue Solid Biker Jacket', N'Polyester', N'November 2020', N'Navy Blue solid Biker jacket, has a stand collar, 5 pockets, zip closure, long sleeves, straight hem, and polyester lining', N'Black', N'Regular', N'Long Sleeves', N'Casual', N'Solid', N'Medium', N'Stand Collar', N'Hand-wash', N'Truecom Retail', N'$135', N'.jpg', 2)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductReviews] ON 
GO
INSERT [dbo].[ProductReviews] ([ReviewID], [Name], [Rating], [ReviewText], [ProductID], [ReviewDate]) VALUES (1, N'Rishi', 2, N'Great fitting with nice fabric', 1, CAST(N'2021-02-13T15:06:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[ProductReviews] OFF
GO
SET IDENTITY_INSERT [dbo].[Studios] ON 
GO
INSERT [dbo].[Studios] ([StudioID], [Title], [StudioDesc], [PostDate], [Extension]) VALUES (1, N'Dusty Pink Solid Single-Breasted Casual Blazer', N'Dusty pink casual blazer, has a notched lapel, single-breasted with a double-button closure, long sleeves, three pockets, and a double-vented back. #FormalWear #Classic #menformal #VdayDateNightLooks
', CAST(N'2021-02-08T14:26:00.0000000' AS DateTime2), N'.jpg')
GO
INSERT [dbo].[Studios] ([StudioID], [Title], [StudioDesc], [PostDate], [Extension]) VALUES (2, N'Men Black Slim Fit Checked Formal Trousers', N'Casual to classic Chic! I alwasy pick key pieces that i can style at least three different ways. #MyntraSays #StayStlish #WesternLook #Classic #MenVdayLook', CAST(N'2021-02-08T14:27:00.0000000' AS DateTime2), N'.jpg')
GO
INSERT [dbo].[Studios] ([StudioID], [Title], [StudioDesc], [PostDate], [Extension]) VALUES (3, N'Men black & White Slim Fit Printed Formal Shirt', N'I know its super cool when you wear formals that match your style. #myntraspotlight #style #cool #Liveformal', CAST(N'2021-02-15T14:28:00.0000000' AS DateTime2), N'.jpg')
GO

SET IDENTITY_INSERT [dbo].[Studios] OFF
GO

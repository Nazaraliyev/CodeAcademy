USE [SixteenClothingDb]
GO
SET IDENTITY_INSERT [dbo].[Specialities] ON 

INSERT [dbo].[Specialities] ([Id], [Name]) VALUES (1, N'CO-Founder')
INSERT [dbo].[Specialities] ([Id], [Name]) VALUES (2, N'Product Expert')
INSERT [dbo].[Specialities] ([Id], [Name]) VALUES (3, N'Chief Marketing')
INSERT [dbo].[Specialities] ([Id], [Name]) VALUES (4, N'Product Specialist')
INSERT [dbo].[Specialities] ([Id], [Name]) VALUES (5, N'Product Photographer')
INSERT [dbo].[Specialities] ([Id], [Name]) VALUES (6, N'General Manager')
SET IDENTITY_INSERT [dbo].[Specialities] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamMembers] ON 

INSERT [dbo].[TeamMembers] ([Id], [Name], [Surname], [Img], [Text], [SpecialityId]) VALUES (1, N'Johnny', N'William', N'team_01.jpg', N'Lorem ipsum dolor sit amet, consectetur adipisicing itaque corporis nulla.', 1)
INSERT [dbo].[TeamMembers] ([Id], [Name], [Surname], [Img], [Text], [SpecialityId]) VALUES (2, N'Karry', N'Pitcher', N'team_02.jpg', N'Lorem ipsum dolor sit amet, consectetur adipisicing itaque corporis nulla.', 2)
INSERT [dbo].[TeamMembers] ([Id], [Name], [Surname], [Img], [Text], [SpecialityId]) VALUES (3, N'Michael', N'Soft', N'team_03.jpg', N'Lorem ipsum dolor sit amet, consectetur adipisicing itaque corporis nulla.', 3)
INSERT [dbo].[TeamMembers] ([Id], [Name], [Surname], [Img], [Text], [SpecialityId]) VALUES (4, N'Michael', N'Soft', N'team_04.jpg', N'Lorem ipsum dolor sit amet, consectetur adipisicing itaque corporis nulla.', 4)
INSERT [dbo].[TeamMembers] ([Id], [Name], [Surname], [Img], [Text], [SpecialityId]) VALUES (5, N'Michael', N'Soft', N'team_05.jpg', N'Lorem ipsum dolor sit amet, consectetur adipisicing itaque corporis nulla.', 5)
INSERT [dbo].[TeamMembers] ([Id], [Name], [Surname], [Img], [Text], [SpecialityId]) VALUES (6, N'Michael', N'Soft', N'team_06.jpg', N'Lorem ipsum dolor sit amet, consectetur adipisicing itaque corporis nulla.', 6)
SET IDENTITY_INSERT [dbo].[TeamMembers] OFF
GO
SET IDENTITY_INSERT [dbo].[MemberSosialNetworks] ON 

INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (1, N'Facebook', N'fa fa-facebook', N'#', 1)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (2, N'Linkedin', N'fa fa-linkedin', N'#', 1)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (3, N'Twitter', N'fa fa-twitter', N'#', 1)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (4, N'Behance', N'fa fa-behance', N'#', 1)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (5, N'Facebook', N'fa fa-facebook', N'#', 2)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (6, N'Twitter', N'fa fa-twitter', N'#', 2)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (7, N'Behance', N'fa fa-behance', N'#', 2)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (8, N'Linkedin', N'fa fa-linkedin', N'#', 2)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (9, N'Facebook', N'fa fa-facebook', N'#', 3)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (10, N'Facebook', N'fa fa-facebook', N'#', 3)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (11, N'Facebook', N'fa fa-facebook', N'#', 3)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (12, N'Facebook', N'fa fa-facebook', N'#', 3)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (13, N'Facebook', N'fa fa-facebook', N'#', 4)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (14, N'Facebook', N'fa fa-facebook', N'#', 4)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (15, N'Facebook', N'fa fa-facebook', N'#', 4)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (16, N'Facebook', N'fa fa-facebook', N'#', 4)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (17, N'Facebook', N'fa fa-facebook', N'#', 5)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (18, N'Facebook', N'fa fa-facebook', N'#', 5)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (19, N'Facebook', N'fa fa-facebook', N'#', 5)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (20, N'Facebook', N'fa fa-facebook', N'#', 5)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (21, N'Facebook', N'fa fa-facebook', N'#', 6)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (22, N'Facebook', N'fa fa-facebook', N'#', 6)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (23, N'Facebook', N'fa fa-facebook', N'#', 6)
INSERT [dbo].[MemberSosialNetworks] ([Id], [Name], [Icon], [NLinkame], [TeamMembersId]) VALUES (24, N'Facebook', N'fa fa-facebook', N'#', 6)
SET IDENTITY_INSERT [dbo].[MemberSosialNetworks] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211220175507_init', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211220190550_UpdateSetting', N'5.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211220190739_UpdateSettingContact', N'5.0.13')
GO
SET IDENTITY_INSERT [dbo].[HomeBanners] ON 

INSERT [dbo].[HomeBanners] ([Id], [SubHeader], [Header], [Img]) VALUES (1, N'BEST OFFER', N'Get your best products', NULL)
INSERT [dbo].[HomeBanners] ([Id], [SubHeader], [Header], [Img]) VALUES (2, N'FLASH DEALS', N'New Arrivals On Sale', NULL)
INSERT [dbo].[HomeBanners] ([Id], [SubHeader], [Header], [Img]) VALUES (3, N'LAST MINUTE', N'Grab last minute deals', NULL)
SET IDENTITY_INSERT [dbo].[HomeBanners] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (1, N'NoName', N'client-01.png')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (2, N'NoName', N'client-01.png')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (3, N'NoName', N'client-01.png')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (4, N'NoName', N'client-01.png')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (5, N'NoName', N'client-01.png')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (1, N'product_01.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 23, 4, 23, N'dev')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (2, N'product_02.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 33, 5, 43, N'des')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (3, N'product_03.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 45, 4, 12, N'gra')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (4, N'product_04.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 34, 5, 42, N'des')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (5, N'product_05.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 65, 5, 44, N'gra')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (6, N'product_06.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 12, 4, 50, N'des')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (7, N'product_01.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 34, 5, 28, N'dev')
INSERT [dbo].[Products] ([Id], [Img], [Name], [Text], [Price], [Star], [Preview], [ClassName]) VALUES (8, N'product_02.jpg', N'Tittle goes here', N'Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.', 45, 5, 23, N'gra')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Qualities] ON 

INSERT [dbo].[Qualities] ([Id], [Header], [Text]) VALUES (1, N'Customer Relations', N'Lorem ipsum dolor sit amet, consectetur an adipisicing elit. Itaque, corporis nulla at quia quaerat.')
INSERT [dbo].[Qualities] ([Id], [Header], [Text]) VALUES (2, N'Customer Relations', N'Lorem ipsum dolor sit amet, consectetur an adipisicing elit. Itaque, corporis nulla at quia quaerat.')
INSERT [dbo].[Qualities] ([Id], [Header], [Text]) VALUES (3, N'Customer Relations', N'Lorem ipsum dolor sit amet, consectetur an adipisicing elit. Itaque, corporis nulla at quia quaerat.')
SET IDENTITY_INSERT [dbo].[Qualities] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [HomeContent], [HomeContentImg], [OurProductSubHeader], [OurProductHeader], [OurProductImg], [AboutUsSubHeader], [AboutUsHeader], [AboutUsImg], [AboutUsContent], [AboutUsContentImg], [ContactUsSubHeader], [ContactUsHeader], [ContactUsImg], [ContactUsContent], [ContactUsLocation]) VALUES (1, N'CLOTHING', N'This template is free to use for your business websites. However, you have no permission to redistribute the downloadable ZIP file on any template collection website. Contact us for more info.', N'feature-image.jpg', N'NEW ARRIVALS', N'SIXTEEN PRODUCTS', NULL, N'ABOUT US', N'OUR COMPANY', NULL, N'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sed voluptate nihil eum consectetur similique? Consectetur, quod, incidunt, harum nisi dolores delectus reprehenderit voluptatem perferendis dicta dolorem non blanditiis ex fugiat. Lorem ipsum dolor sit amet, consectetur adipisicing elit.

Lorem ipsum dolor sit amet, consectetur adipisicing elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti eum ratione ex ea praesentium quibusdam? Aut, in eum facere corrupti necessitatibus perspiciatis quis.', N'feature-image.jpg', N'CONTACT US', N'LET’S GET IN TOUCH', N'', N'Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.

Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti.', NULL)
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[SosialMedias] ON 

INSERT [dbo].[SosialMedias] ([Id], [Name], [Icon], [Link]) VALUES (1, N'Facebook', N'fa fa-facebook', N'#')
INSERT [dbo].[SosialMedias] ([Id], [Name], [Icon], [Link]) VALUES (2, N'Twitter', N'fa fa-twitter', N'#')
INSERT [dbo].[SosialMedias] ([Id], [Name], [Icon], [Link]) VALUES (3, N'Linkedin', N'fa fa-linkedin', N'#')
INSERT [dbo].[SosialMedias] ([Id], [Name], [Icon], [Link]) VALUES (4, N'Behance', N'fa fa-facebook', N'#')
SET IDENTITY_INSERT [dbo].[SosialMedias] OFF
GO

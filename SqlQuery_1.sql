﻿CREATE TABLE [dbo].[Books] (
    [Id] [int] NOT NULL IDENTITY,
    [BookName] [nvarchar](max) NOT NULL,
    [RentPrice] [decimal](18, 2) NOT NULL,
    [ApplicationUserId] [nvarchar](128),
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_ApplicationUserId] ON [dbo].[Books]([ApplicationUserId])
ALTER TABLE [dbo].[Books] ADD CONSTRAINT [FK_dbo.Books_dbo.AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[AspNetUsers] ([Id])
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201801072216443_RegistrationChanges', N'BookLibrary.Models.ApplicationDbContext',  0x1F8B0800000000000400DD5CDB6EE4B8117D0F907F10F49404DE962F99C1C4E8DE85B76D6F8CF806B7679137832DB1DBC44854AF44796D04FB65FB904FCA2F84D495E24577ABE5C5BCB845F254B1582C569155F3BFDFFF3BFFE1D5738D171884C8C70BF36876681A10DBBE83F076614664F3DD17F387EFFFFCA7F985E3BD1A3F67FD4E583F3A12870BF39990DDA96585F633F44038F3901DF8A1BF2133DBF72CE0F8D6F1E1E13FACA3230B5208936219C6FC21C2047930FE417F2E7D6CC31D89807BE33BD00DD3EFB46515A31AB7C083E10ED87061FEE8FBDFAED13A00C1DB2CE96D1A672E029493157437A60130F6092094CFD3AF215C91C0C7DBD58E7E00EEE3DB0ED27E1BE08630E5FFB4E8DE742A87C76C2A56313083B2A390F85E4BC0A39354369638BC9384CD5C76547A1754CAE48DCD3A9660223CD310099D2EDD8075520977C63E1D185CC341AE06545BD8BF036319B9240AE002C38804C03D30EEA3B58BEC7FC1B747FF1BC40B1CB92ECF18658DB6953ED04FF781BF8301797B809B94DD2BC734ACF2384B1C980FE3C62493B9C2E4E4D8346E2971B07661BEEEDCC457C40FE04F10C30010E8DC0342608019068C252751176831A9B0BF328A54D9E8BE318D1BF07A0DF1963C2F4CFAA7695CA257E8645F522EBE6244B7191D4482082AB8ACA6FC4019BC0F909D933E8736F2806B1AF701FD2BDDCD5F4C63650306AA92433585B3DD8E2E612C26BA8D8242AC8A491E1D7F69344981E22D7841DB9882409B11348D07E8C68DE133DA259B3B56C6A7A4F532F0BD07DF4D5721FEF8B4F2A32016892FB63C82600B499983B955EC8FCA5D2388A2E50612467FCCBDD463D15BEADD8507905B41F6F8D3E72EBAA6A2428F9D0D0A3C98CF92AE8C0B016ECDF33D08C35FFDC0F927089F07B005D5C456D08E02AAA02B02BCDDBB53BB7FF631BC8DBC35D3FBF1680DB6348FBFFA97C0A666FE02B351BDF1AE7DFB9B1F910BEC9CD323E32BB173034C7F3E22AF39C020EC9CD9360CC34BAACCD059FAD4ABAA3BFCAAE19881AA39D09AEEBF3ACA5AE3BF7401F242A5F9174CE953D6B5380BD43DA48341D34D754A54B17AED6F116EC66AD655CF6AD2A396D5B45B5B561958334ED39E7A46E30EB57C26BD7A9DBB991BC6F0E215AA3A796F72AFF82CDCDD4232CB46CF12DCCB80625223FD6D26C11E188D071707F671D303FBE468BD39F9F2E933704E3EFF1D9E7CFA233AC28379882DED55BC7C8CE8BB9F4D31A59F811B0D4DAAD36E888DC0F0BB21869DFE6E88D9A49F5F90C3BC12AB7E44D699C237EA9FE973DB3D277036F676284D736CE2E3D8804EDB859D45C3EF16863AFDCDA25665655736A12E5ABF2FEB9FF13B318D1B5EDB3E86A67D941B867D07386CBBA85D717EBD9FD26E851F2EB74A4EB8A24B1B0FFC2C0C7D1BC55CA9AFBEB288AB3C531A0C1BCDC2AF44E68AA883AE00D550C4BE51BEE8D29BA2BEDDE173E842028D333BB95B5F82D0068E2C773A37A7257F998C38FE14B14799C3BF4984E94E80011B05D8CD5248F719C244DE3608DB6807DC4612134637DC764C08391DB1E51CEE2066936B2492260C684F182BA725AC509DA4E616A789ED14348DB39B2A8018744F4D4185685FA3A06938308A829625B607052D8BE4C3296872BDD274FD85BB96A9A967F99247A39D893F348A7296C4B507DD2CC963F2AA59BCA6E9D65BF1B456AC71F2985CB7AE2A3085C2D4E8F3E16C76348CCA485C8CA02692189BD0543CC0EE454B144EA96E85AB3C54D936A8ECC23BD9AD0ABF787CA3A597D208AAA8974413E2EA1B827751C42442A163081D010379539CAF59237C258A589B4E2C0DB7C3345C13358381AF2029E5C5144151C9C24906AD3C368DD3A4C19245ABC191220E15A8222C69019B3D4255C2A6CE640BD8F4C5A81235D94F35A075404A104E7F0A24DD4B21D7B9FA4D5154F0C6316E3EA75C33A4CDD2381EE5B054DA211AC0B2243A4829D38F7A29A9C2AC3681562F29094191464AD964069752AAA5F54252B8FA2D9CFD5E222A3BE61A09A513E92D202E2B4B168AC6C9AC7133398E5546B8C6AFAC135D8739AAAEE6E4C9D6F94A4DBD256E02CA456AEADC0CB4F0D97D617E1AE76D732BC9D04D3FCC2D4D2AEFFC06EC76086FB9D4DEF48BB14AF27A97DFADDA27BC7A098665878ABCD79CDB9C12F103B085422B254D39BD444148CE01016BC0EE72978E277553FA1E9A032D23C9B917F20266A75CD699FD5D0C50E4E12A7CB474EC259D98C7BCBCF8215FDC3DD2308365560317048AEBF8A5EF461ED63B9BFAD1453A2C8F517C6D8EC4A5B7F250DCE7E6588A388AC76C106631BD16E42CF9BFD26A4AC14959331AE98DCE82B4521CD10F6DAF43B508EFA34E6926280F907E6A89C125134A605C5B73D472BE278F596E698E282475F29042530B2EF9D4CD12937C43273C8D44D53D9A539093357974B9B539B2226D9387563477C056F02CB6B5305B726667C96CC9CDCDB18B344F1EB2F83A1903A8887A7A5A4339806E6F0F1B60BC8F45549D5FFA434B87C225CDF140DCE79658695A9C04967E9FA4366903D8CEDA94DC9BF4D3260D86DEF294D2CDCA86A732474E8F59CA212B19F7AA1C3A3D5E3B9D9D8066E8A2F6CE8A11DF5AF5D30B35C4FB9A89ECAEB7E4806BEE7FF7B670832E56CF856AB748FD4E02F9F4DECBC92D5D0C885D72EAF905817011304F83F2FAC25F294A4FBAB08AC7C4305157F92D24D09BB10EB3D52FEED24590394659871B80D10686244979338F0F8F8E85DAE1E9D4F15A61E8B88A4B0DB198B7BC5623E4E92126D1DA728196297962212D7E0181FD0C82BF78E0F5AFFD8B639DD18A6333C6156F5257D881AF0BF33F31C4A971F5EF2709E5C0B80BA89E9E1A87C66F722664C1638F2A82CA587E0CFD2924A49F5FFB4251256A9CC95925350DA8547CB84664909A50AD5A77AEFBEC85A8A8ED1C0A6F1011EA6A37BB6069EB361DFA93C4759BED26ABAEE3ECC29AB6863336B53D2B389B1BA46C64FCF9C0B80ABF62F44B441B1EA934047B24ECACA1EA3414C1F4873DD27A9C0BED0E836E8572BD36BA5C0CD702AE47C15B07CDF860B562839D8E8A52B0C1B0F7A9DADDEBBF3A28CFE8B553FB3613E58AAA56DC2443C75CD9AEAB3A11FFB5DB29CD26FDFEA7F4D0854013485D5764CEEDBFDC67CC8CCFAA178F8925A6F72BEA9998B2A5F994FB2FDD195BD9740F221357B656053A13D3B5244176EF7538636B9AE6E27E628A565F6ED343B9940532E51CC90EC53B1F451934C9717FB8A29AA9D4D1ECD3D6D4BCD64DC3D0ECBD5046CE6915D7B445054CF2D2B6309DB54F573C8926588B9C432CC24A564BA220F550114BFEC30B752EB74852E1CA4B44157DAAC96A4A2EAA68A79E5D25EDB44F356D4D214315ED64FB55924EBA545356E789EB08D710AD23A826B6E7EA9E520A7D4D45575DB8599941F6918A7906114A697B6812A13E4EEDCE2022E137903A056802B53A434D9C3F70B4753ED32BD451AE8F6A6D4659E5168539729E0DF539B8FF869FFA3D21DA1610EC3FE5C7D02E791B799F2BBCF133A747E028EB22DC76DE40021CEA8A9C05046D804D68337BF58CFFF3A5F82589BDBDAFA17385EF22B28B089D32F4D66EE90986394F55F4E3EAA332CFF3BB1DFB150E3105CA2662AFC577F8C708B94ECEF7A5E25E5503C1BCB2F48D91AD25616F8DDBB71CE9D6C70D8152F1E5CEE423F4762E050BEFF00ABCC02EBC51F5BB865B60BF156F523A90FA85288B7D7E8EC036005E986214E3E94FAAC38EF7FAFDFF0145072DD88D620000 , N'6.1.3-40302')

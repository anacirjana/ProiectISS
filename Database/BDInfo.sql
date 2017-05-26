USE ProiectISS

INSERT INTO CommitteeMembers 
	VALUES ('ElaineB','init1234','Benes','Elaine','elaine@yahoo.com','www.benes.com','Math&CS','co-chair'),
		   ('StevenH','stev1992','Hyde','Steven','steven@yahoo.com','www.stehyde.com','Astrology','chair'),
		   ('BenG','gonzo','Gonzalez','Ben','gonzales@gmail.com','www.bengonz.ro','Astrology','co-chair'),
		   ('TrishW','well20','Wellington','Trish','trish@hotmail.com','www.trny.fr','Medicine','co-chair'),
		   ('AlexM','init9090','Mahone','Alex','mahone@gmail.com','www.alex.ro','Math&CS','normal'),
		   ('SonyaB','sonya7','Blade','Sonya','blade@hotmali.com','www.blazer.com','Medicine','chair'),
		   ('JohnnyC','johncg','Cage','Johnny','johnny@yahoo.com','www.cage.ro','Astrology','chair'),
		   ('TonyA','alme12','Almeida','Tony','almeida@gmail.com','www.almaton.fr','Math&CS','normal'),
		   ('ChandlerB','bingbing','Bing','Chandler','chandler@hotmail.com','www.bingit.ro','Math&CS','chair'),
		   ('AndiP','prenda','Prendergast','Andi','andi@yahoo.com','www.prender.ro','Medicine','chair'),
		   ('MortimerM','morty','Manta','Mortimer','manta@gmail.com','www.mortimer.com','Astrology','normal')

INSERT INTO Listeners
	VALUES ('BillyC','bluerang','billy@hotmail.com','Cranston','Billy'),
		   ('SkylerW','meth20','white@gmail.com','White','Skyler'),
		   ('GeorgeC','consty','contanza@gmail.com','Costanza','George'),
		   ('HankS','hank40','hank@yahoo.ro','Schrader','Hank'),
		   ('KimberlyH','kimber','hart@gmail.com','Hart','Kimberly'),
		   ('BertW','wysco','bert@hotmail.com','Wysocki','Bert'),
		   ('HenryD','dunno','henry@yahoo.com','Dunn','Henry'),
		   ('KittyF','kitty','kitty@yahoo.com','Forman','Kitty'),
		   ('MichaelK','kelso','kelso@gmail.com','Kelso','Michael'),
		   ('TedG','galler','galler@hotmail.com','Gallagher','Ted'),
		   ('KimB','kimber','bauer@yahoo.com','Bauer','Kim')

INSERT INTO Sections
	VALUES (1,'Medicine'),
		   (2,'Math&CS'),
		   (3,'Enviroment')

INSERT INTO Papers
	VALUES (1,'Bayes Theorem','#spam#formula','Internet','Bill Overbeck','Science Daily','20-05-2017','path',2),
		   (2,'Fouriner Analysis','#frequance','Music','Racer Trey','Science Daily','14-02-2017','path',2),
		   (3,'Cures For Epilepsy','#cure#venom','Innovations','Sara Tancredi','Med Talk','23-03-2017','path',1),
		   (4,'Global Warming','#heat#world','Global Issues','Donna Pinciotti','World News','02-04-2017','path',3),
		   (5,'Travelling Salesman','#graph#criminology','Math','Abby Mills','Math Today','20-03-2017','path',2),
		   (6,'Limitless Pill','#memory#pill','Innovations','Morgan Gretchen','Med Talk','13-02-2017','path',1),
		   (7,'Saving The World','#world#all','Global Issues','Ross Geller','World News','12-04-2017','path',3)

INSERT INTO Speakers
	VALUES ('SaraT','pass1919','tancredi@gmail.com','Tancredi','Sara',3),
		   ('RossG','rossal','geller@yahoo.com','Geller','Ross',7),
		   ('DonnaP','donna','donna@yahoo.com','Pinciotti','Donna',4),
		   ('BillO','biller','billy@gmail.com','Overbeck','Bill',1),
		   ('TreyR','treice','racer@hotmail.com','Racer','Trey',2),
		   ('GretchenM','morgan','morgan@yahoo.com','Morgan','Gretchen',6),
		   ('AbbyM','ablly','abby@gmail.com','Mills','Abby',5)

INSERT INTO Reviews
	VALUES (1,'SonyaB',2,'accept','Should use a more formal approach.'),
		   (2,'AndiP',5,'strong accept','No comment.'),
		   (3,'StevenH',3,'weak accept','More examples.'),
		   (4,'JohnnyC',2,'strong accept','Interesting idea for undersatanding how to copy music.'),
		   (5,'BenG',4,'accept','Cannot wait for the presentation.'),
		   (6,'ChandlerB',1,'weak accept','Would need a liitle more documentation')

INSERT INTO Bidding
	VALUES ('ElaineB',1,1),
		   ('SonyaB', 2,1),
		   ('StevenH',2,0),
		   ('BenG',4,1),		   
		   ('StevenH',3,1),
		   ('ChandlerB',1,1),
		   ('BenG',3,0),
		   ('MortimerM',5,0),
		   ('BenG',4,1),
		   ('JohnnyC',2,1),
		   ('AndiP',5,1)

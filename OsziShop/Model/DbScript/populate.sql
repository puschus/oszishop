SELECT * FROM AspNetUsers where LockoutEnabled = 1;

UPDATE AspNetUsers
SET LockoutEnabled = 0
where LockoutEnabled = 1;

UPDATE AspNetUsers
SET LockoutEnabled = 0
where FIRST_NAME = 'Jakob';

describe ARTICLES;

Set FOREIGN_KEY_CHECKS = 1;

INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (1, 'Article1', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (2, 'Article2', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (3, 'Article3', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (4, 'Article4', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (5, 'Article5', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (6, 'Article6', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (7, 'Article7', 'Meddl', 300);
INSERT INTO ARTICLES (ARTICLE_ID, DESIGNATION, DESCRIPTION, PRICE) VALUES (8, 'Article8', 'Meddl', 300);


insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('DSO RTM 3000; 100 MHz; 2 Kanäle', 4560.20, 'Digital-Speicher-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('MSO RTM 3000; 100 MHz; 2 Kanäle', 6516.13, 'Mixed-Signal-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('DSO RTM 3000; 100 MHz; 4 Kanäle', 5424.13, 'Digital-Speicher-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('MSO RTM 3000; 100 MHz; 4 Kanäle', 7392.04, 'Mixed-Signal-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('DSO RTC 1000; 100 MHz; 2 Kanäle', 1464.12, 'Digital-Speicher-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('DSO RTM 3000; 1 GHz; 2 Kanäle', 14268.04, 'Digital-Speicher-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('DSO RTB 2002; 100 MHz; 2 Kanäle', 2316.17, 'Digital-Speicher-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('MSO RTC 1000; 100 MHz; 2 Kanäle', 2040.16, 'Mixed-Signal-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('MSO RTM 3000; 1 GHz; 2 Kanäle', 16236.04, 'Mixed-Signal-Oszilloskop');
insert into articles
(DESIGNATION, PRICE, DESCRIPTION)
VALUES ('MSO RTB 2002; 100 MHz; 2 Kanäle', 3408.17, 'Mixed-Signal-Oszilloskop');

SELECT * FROM ARTICLES;

DROP DATABASE oszidb;
CREATE DATABASE oszidb;

UPDATE ARTICLES
SET PRICE = 4560.21
where ARTICLE_ID = 1;
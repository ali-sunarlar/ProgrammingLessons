
create database AVM2
create table Plaza2
(
PlazaNo int,
PlazaAd varchar(10)
)
use AVM2
create table Plaza
(
PlazaNo int,
PlazaAd varchar(10)
)
alter table Plaza add CalisanSayisi int
alter table Plaza add Mail varchar(30)

insert into Plaza(PlazaNo,PlazaAd) values(48,'ZZZ')
select * from Plaza

update Plaza set PlazaAd='Simay' where PlazaNo=48
update Plaza set CalisanSayisi= 215
update Plaza set Mail='a@h-gmail.com'

delete from Plaza where PlazaNo=48


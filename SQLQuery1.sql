/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/11/2024 11:49:18 PM                        */
/*==============================================================*/


if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_ADMIN')
          and type = 'TR')
   drop trigger CLR_TRIGGER_ADMIN
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_AUTHOR')
          and type = 'TR')
   drop trigger CLR_TRIGGER_AUTHOR
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_BOOK')
          and type = 'TR')
   drop trigger CLR_TRIGGER_BOOK
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_BOOK_LOANS')
          and type = 'TR')
   drop trigger CLR_TRIGGER_BOOK_LOANS
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_COMPLAINT')
          and type = 'TR')
   drop trigger CLR_TRIGGER_COMPLAINT
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_PHONE')
          and type = 'TR')
   drop trigger CLR_TRIGGER_PHONE
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_PUBLISH')
          and type = 'TR')
   drop trigger CLR_TRIGGER_PUBLISH
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_RSERVE')
          and type = 'TR')
   drop trigger CLR_TRIGGER_RSERVE
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_REVIEW')
          and type = 'TR')
   drop trigger CLR_TRIGGER_REVIEW
go

if exists (select 1
          from sysobjects
          where id = object_id('CLR_TRIGGER_STUDENT')
          and type = 'TR')
   drop trigger CLR_TRIGGER_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK_LOANS') and o.name = 'FK_BOOK_LOA_LOAN_BOOK_BOOK')
alter table BOOK_LOANS
   drop constraint FK_BOOK_LOA_LOAN_BOOK_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK_LOANS') and o.name = 'FK_BOOK_LOA_LOAN_STUD_STUDENT')
alter table BOOK_LOANS
   drop constraint FK_BOOK_LOA_LOAN_STUD_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COMPLAINT') and o.name = 'FK_COMPLAIN_REPORT_STUDENT')
alter table COMPLAINT
   drop constraint FK_COMPLAIN_REPORT_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONE_ADMIN') and o.name = 'FK_PHONE_AD_HAS2_ADMIN')
alter table PHONE_ADMIN
   drop constraint FK_PHONE_AD_HAS2_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONE_STUDENT') and o.name = 'FK_PHONE_ST_REFERENCE_STUDENT')
alter table PHONE_STUDENT
   drop constraint FK_PHONE_ST_REFERENCE_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PUBLISH') and o.name = 'FK_PUBLISH_PUBLISH_BOOK')
alter table PUBLISH
   drop constraint FK_PUBLISH_PUBLISH_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PUBLISH') and o.name = 'FK_PUBLISH_PUBLISH2_AUTHOR')
alter table PUBLISH
   drop constraint FK_PUBLISH_PUBLISH2_AUTHOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVE') and o.name = 'FK_RESERVE_RSERVE_STUDENT')
alter table RESERVE
   drop constraint FK_RESERVE_RSERVE_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVE') and o.name = 'FK_RESERVE_RSERVE2_BOOK')
alter table RESERVE
   drop constraint FK_RESERVE_RSERVE2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REVIEW') and o.name = 'FK_REVIEW_WRITE_STUDENT')
alter table REVIEW
   drop constraint FK_REVIEW_WRITE_STUDENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK_LOANS')
            and   name  = 'LOAN_STUDENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK_LOANS.LOAN_STUDENT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK_LOANS')
            and   type = 'U')
   drop table BOOK_LOANS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPLAINT')
            and   type = 'U')
   drop table COMPLAINT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHONE_ADMIN')
            and   name  = 'HAS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHONE_ADMIN.HAS2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONE_ADMIN')
            and   type = 'U')
   drop table PHONE_ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONE_STUDENT')
            and   type = 'U')
   drop table PHONE_STUDENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBLISH')
            and   name  = 'PUBLISH2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBLISH.PUBLISH2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBLISH')
            and   name  = 'PUBLISH_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBLISH.PUBLISH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBLISH')
            and   type = 'U')
   drop table PUBLISH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVE')
            and   name  = 'RSERVE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVE.RSERVE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVE')
            and   name  = 'RSERVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVE.RSERVE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVE')
            and   type = 'U')
   drop table RESERVE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REVIEW')
            and   type = 'U')
   drop table REVIEW
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT')
            and   type = 'U')
   drop table STUDENT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   EMAIL                varchar(50)          not null,
   FIRST_NAME           varchar(20)          not null,
   LAST_NAME            varchar(20)          not null,
   PASSWORD             varchar(50)          not null,
   SIX                  varchar(10)          not null,
   constraint PK_ADMIN primary key (EMAIL)
)
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   EMAIL_A              varchar(50)          not null,
   FIRST_NAME           varchar(20)          not null,
   LAST_NAME            varchar(20)          not null,
   NATIONALITY          varchar(50)          not null,
   constraint PK_AUTHOR primary key nonclustered (EMAIL_A)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   BOOK_ID              numeric              not null,
   NAME                 varchar(50)          not null,
   LANGUAGE             varchar(50)          not null,
   AUTHOR               varchar(50)          not null,
   PRINT_YEAR           varchar(50)          not null,
   CATEGORY             varchar(50)          not null,
   constraint PK_BOOK primary key nonclustered (BOOK_ID)
)
go

/*==============================================================*/
/* Table: BOOK_LOANS                                            */
/*==============================================================*/
create table BOOK_LOANS (
   BOOK_ID              numeric              not null,
   EMAIL                varchar(50)          not null,
   U_ID                 varchar(20)          not null,
   LOAN_NO              numeric              not null,
   STATUS               varchar(20)          not null,
   LOAN_DATE            datetime             null,
   DUE_DATE             datetime             null,
   constraint PK_BOOK_LOANS primary key nonclustered (BOOK_ID, EMAIL, U_ID, LOAN_NO)
)
go

/*==============================================================*/
/* Index: LOAN_STUDENT_FK                                       */
/*==============================================================*/
create index LOAN_STUDENT_FK on BOOK_LOANS (
EMAIL ASC,
U_ID ASC
)
go

/*==============================================================*/
/* Table: COMPLAINT                                             */
/*==============================================================*/
create table COMPLAINT (
   EMAIL                varchar(50)          not null,
   U_ID                 varchar(20)          not null,
   COMPLAINT_NO         numeric              not null,
   DATE                 datetime             null,
   DESCRIPTION          varchar(100)         null,
   constraint PK_COMPLAINT primary key nonclustered (EMAIL, U_ID, COMPLAINT_NO)
)
go

/*==============================================================*/
/* Table: PHONE_ADMIN                                           */
/*==============================================================*/
create table PHONE_ADMIN (
   USER_EMAIL           varchar(50)          not null,
   PHONE                varchar(20)          not null,
   constraint PK_PHONE_ADMIN primary key nonclustered (USER_EMAIL, PHONE)
)
go

/*==============================================================*/
/* Index: HAS2_FK                                               */
/*==============================================================*/
create index HAS2_FK on PHONE_ADMIN (
USER_EMAIL ASC
)
go

/*==============================================================*/
/* Table: PHONE_STUDENT                                         */
/*==============================================================*/
create table PHONE_STUDENT (
   PHONE                varchar(20)          not null,
   EMAIL                varchar(50)          not null,
   U_ID                 varchar(20)          not null,
   constraint PK_PHONE_STUDENT primary key (PHONE, EMAIL, U_ID)
)
go

/*==============================================================*/
/* Table: PUBLISH                                               */
/*==============================================================*/
create table PUBLISH (
   BOOK_ID              numeric              not null,
   EMAIL_A              varchar(50)          not null,
   constraint PK_PUBLISH primary key (BOOK_ID, EMAIL_A)
)
go

/*==============================================================*/
/* Index: PUBLISH_FK                                            */
/*==============================================================*/
create index PUBLISH_FK on PUBLISH (
BOOK_ID ASC
)
go

/*==============================================================*/
/* Index: PUBLISH2_FK                                           */
/*==============================================================*/
create index PUBLISH2_FK on PUBLISH (
EMAIL_A ASC
)
go

/*==============================================================*/
/* Table: RESERVE                                               */
/*==============================================================*/
create table RESERVE (
   EMAIL                varchar(50)          not null,
   U_ID                 varchar(20)          not null,
   BOOK_ID              numeric              not null,
   STATUS               varchar(20)          not null,
   RESERVATION_DATE     datetime             null,
   constraint PK_RESERVE primary key (EMAIL, U_ID, BOOK_ID)
)
go

/*==============================================================*/
/* Index: RSERVE_FK                                             */
/*==============================================================*/
create index RSERVE_FK on RESERVE (
EMAIL ASC,
U_ID ASC
)
go

/*==============================================================*/
/* Index: RSERVE2_FK                                            */
/*==============================================================*/
create index RSERVE2_FK on RESERVE (
BOOK_ID ASC
)
go

/*==============================================================*/
/* Table: REVIEW                                                */
/*==============================================================*/
create table REVIEW (
   EMAIL                varchar(50)          not null,
   U_ID                 varchar(20)          not null,
   REVIEW_NO            numeric              not null,
   DATE                 datetime             null,
   DESCRIPTION          varchar(100)         null,
   RATING               varchar(10)          not null,
   constraint PK_REVIEW primary key nonclustered (EMAIL, U_ID, REVIEW_NO)
)
go

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
create table STUDENT (
   EMAIL                varchar(50)          not null,
   U_ID                 varchar(20)          not null,
   LEVEL                numeric(1)           not null,
   FIRST_NAME           varchar(20)          null,
   LAST_NAME            varchar(20)          null,
   SIX                  varchar(10)          null,
   PASSWORD             varchar(50)          null,
   constraint PK_STUDENT primary key nonclustered (EMAIL, U_ID)
)
go

alter table BOOK_LOANS
   add constraint FK_BOOK_LOA_LOAN_BOOK_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table BOOK_LOANS
   add constraint FK_BOOK_LOA_LOAN_STUD_STUDENT foreign key (EMAIL, U_ID)
      references STUDENT (EMAIL, U_ID)
go

alter table COMPLAINT
   add constraint FK_COMPLAIN_REPORT_STUDENT foreign key (EMAIL, U_ID)
      references STUDENT (EMAIL, U_ID)
go

alter table PHONE_ADMIN
   add constraint FK_PHONE_AD_HAS2_ADMIN foreign key (USER_EMAIL)
      references ADMIN (EMAIL)
go

alter table PHONE_STUDENT
   add constraint FK_PHONE_ST_REFERENCE_STUDENT foreign key (EMAIL, U_ID)
      references STUDENT (EMAIL, U_ID)
go

alter table PUBLISH
   add constraint FK_PUBLISH_PUBLISH_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table PUBLISH
   add constraint FK_PUBLISH_PUBLISH2_AUTHOR foreign key (EMAIL_A)
      references AUTHOR (EMAIL_A)
go

alter table RESERVE
   add constraint FK_RESERVE_RSERVE_STUDENT foreign key (EMAIL, U_ID)
      references STUDENT (EMAIL, U_ID)
go

alter table RESERVE
   add constraint FK_RESERVE_RSERVE2_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table REVIEW
   add constraint FK_REVIEW_WRITE_STUDENT foreign key (EMAIL, U_ID)
      references STUDENT (EMAIL, U_ID)
go


create trigger CLR_TRIGGER_ADMIN on ADMIN  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_AUTHOR on AUTHOR  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_BOOK on BOOK  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_BOOK_LOANS on BOOK_LOANS  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_COMPLAINT on COMPLAINT  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_PHONE on PHONE_ADMIN  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_PUBLISH on PUBLISH  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_RSERVE on RESERVE  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_REVIEW on REVIEW  insert as
external name %Assembly.GeneratedName%.
go


create trigger CLR_TRIGGER_STUDENT on STUDENT  insert as
external name %Assembly.GeneratedName%.
go


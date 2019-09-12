USE master ;  
GO  
CREATE DATABASE BookClub  
ON   
( NAME = bookclub_dat,  
    FILENAME = 'd:\data\microsoft\sql\bookclub.mdf',  
    SIZE = 10MB,  
    MAXSIZE = 20MB,  
    FILEGROWTH = 1MB )  
LOG ON  
( NAME = bookclub_log,  
    FILENAME = 'd:\data\microsoft\sql\bookclub.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 10MB,  
    FILEGROWTH = 1MB ) ;  
GO
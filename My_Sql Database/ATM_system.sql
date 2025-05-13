create database ATM_system;
use atm_system;

-- User Login table
-- User detail table
-- Accounts table
-- transaction table

create table admin_Login
(
	admin_id int primary key,
    admin_pass varchar(20) not null
);
insert into admin_Login values (100200, "huraira_admin200");
select * from admin_Login;

create table user_Login
(
	user_id int primary key,
    user_pass varchar(20) not null
);
insert into user_Login (user_id, user_pass) values (1020, "huraira_11");
insert into user_Login (user_id, user_pass) values (1200, "noor_33");
select * from user_Login;


create table user_details
(
	det_id int primary key,
    user_id int not null,
    user_name varchar(20),
    user_email varchar(30),
    unique (user_id),
    foreign key (user_id) references user_Login(user_id) on update cascade on delete cascade
);
-- ALTER TABLE user_details MODIFY COLUMN user_no INT primary key;
insert into user_details (det_id ,user_id, user_name, user_email) values (78963 ,1020, "Huraira", "huraira@gmail");
insert into user_details (det_id, user_id, user_name, user_email) values (13597 ,1200, "Noor Ali", "noor@gmail");
select * from user_details;
-- delete from user_details where det_id = 63963;


create table accounts
(
	acc_id int primary key,
    det_id int not null,
    acc_type varchar(20),
    acc_date date,
    unique (det_id),
    foreign key (det_id) references user_details(det_id) on update cascade on delete cascade
);
alter table accounts add column balance decimal(15,2) not null default 0.00;
insert into accounts values (9999, 78963, "saving", '2024-05-13', 65000);
insert into accounts values (3333, 13597, "current", '2024-06-02', 42000);
-- update accounts set balance = 65000 where acc_id = 7777;
select * from accounts;

set sql_safe_updates = 0;

CREATE TABLE bank_account (
    bank_id INT PRIMARY KEY,
    bank_name VARCHAR(50),
    bank_balance DOUBLE NOT NULL
);
insert into bank_account values (486312, "HBL", 450000);

CREATE TABLE transactions (
    trans_id INT AUTO_INCREMENT PRIMARY KEY,
    acc_id INT NOT NULL,
    trans_type varchar(20),
    trans_amount DOUBLE NOT NULL,
    trans_date DATE NOT NULL,
    trans_time TIME NOT NULL,
    FOREIGN KEY (acc_id) REFERENCES accounts(acc_id) ON UPDATE CASCADE ON DELETE CASCADE
);
INSERT INTO transactions (acc_id, trans_type, trans_amount, trans_date, trans_time)
VALUES (9999, 'Deposit', 8000.00, '2024-05-15', '11:30:44');

select * from transactions;
delete from transactions where trans_id = 2;



-- drop table transactions;
-- drop table accounts;
-- drop table user_details;

create database db_user;
create table user_profile(
id serial primary key,
username varchar not null,
password varchar not null, 
fullname varchar not null, 
avatar varchar null, 
birthday timestamp null, 
created_time timestamp not null
);

create table friend(
id serial primary key,  
sender_id int not null,  
receiver_id int not null, 
status varchar, 
created_time timestamp not null
);

create table message(
id serial primary key, 
sender_id int not null, 
receiver_id int not null, 
type varchar not null, 
content varchar  null, 
status varchar, 
created_time timestamp not null) ;

insert into user_profile (username, password, fullname, avatar, birthday, created_time) values 
('a', 'a', 'a b c',null, null, now()),
('b', 'b', 'd e f',null, null, now()),
('c', 'c', 'm n p',null, null, now()),
('d', 'd', 'q w e',null, null, now());

insert into friend (sender_id, receiver_id, status, created_time) values
(1, 2, 'accepted', now()),
(2, 3, 'pending', now()),
(3, 4, 'pending', now()),
(3, 1, 'accepted', now()),
(4, 1, 'accepted', now()),
(2, 1, 'accepted', now()),
(2, 4, 'accepted', now());
insert into message (sender_id, receiver_id, type, content, status, created_time) values 
(1, 2, 'text', 'HELLO', 'sent', now()),
(2, 3, 'image', 'HELLO', 'pending_read', now()),
(2, 1, 'file', 'HELLO', 'sent', now()),
(2, 1, 'text', 'HELLO', 'sent', now()),
(3, 4, 'video', 'HELLO', 'read', now()),
(4, 1, 'file', 'HELLO', 'sent', now());


--Lấy id, username, fullname, avatar: của các user có id =  2, 3.
select id, username, fullname, avatar from user_profile where id in (2, 3);

SELECT * FROM pg_stat_activity;
--Lấy các bạn bè(gồm thông tin sau: id, username, fullname, avatar) của user có id = 2.
select a.id, a.username, a.fullname, a.avatar from user_profile a join friend b on a.id = b.receiver_id
where b.sender_id = 2 AND b.status = 'accepted';


--cLấy tin nhắn của user có id = 2 với một nào đó bạn bè (ví dụ: id bạn bè = 3). 
--Các trường lấy ra gồm: message_id, sender_id, receiver_id, type, status, content, created_time.
select id, sender_id, receiver_id, type, status, content,created_time from message where (sender_id = 2 and receiver_id = 1);


--Lấy tin nhắn cuối cùng(last_message) với tất cả bạn bè của user có id = 2.
--Các trường lấy ra gồm: friend_id, mesage_id, type, status, content, sender_id, created_time.
select b.id as Friend_ID, c.id as Message_ID, c.type, c.status, c.content, c.sender_id, c.created_time 
from message c join friend b on b.sender_id = c.sender_id and b.receiver_id = c.receiver_id 
where b.sender_id = 2
and c.id in (select max(id) from message where sender_id = 2 group by receiver_id);

--Lấy dánh sách 10 user(id, username, avatar, birthday) có số lượng bạn bè nhiều nhất trong hệ thống.
SELECT a.id, a.username, a.avatar, a.birthday, b.friend_count FROM user_profile a JOIN 
(SELECT sender_id, COUNT(*) AS friend_count FROM friend WHERE status = 'accepted' GROUP BY sender_id)  --JOIN 2 BẢNG, TRONG ĐÓ BẢNG FRIEND ĐC MODIFIED ĐỂ CÓ CỘT ĐẾM SỐ FRIEND
b ON a.id = b.sender_id ORDER BY b.friend_count DESC LIMIT 10;




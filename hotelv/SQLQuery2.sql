
CREATE TABLE users (
    id int PRIMARY KEY identity (1,1),
    username VARCHAR(50)  NULL, 
    password VARCHAR(255) NULL, 
    role VARCHAR(20)  NULL, 
    status VARCHAR(10)  NULL , 
    date_register DATE  
);

SELECT * FROM users;
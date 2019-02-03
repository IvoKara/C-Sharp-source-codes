CREATE TABLE categories
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	name VARCHAR(30) NOT NULL
);

CREATE TABLE items
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	name VARCHAR(30) NOT NULL,
	price DECIMAL(15,2) NOT NULL,
	category_id INT  NOT NULL,
    CONSTRAINT FOREIGN KEY(category_Id) REFERENCES categories(id)
);

CREATE TABLE employees
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	phone CHAR(12) NOT NULL,
	salary DECIMAL(15,2) NOT NULL
);

CREATE TABLE orders
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	date_time DATETIME NOT NULL,
	employee_id INT  NOT NULL,
    CONSTRAINT FOREIGN KEY(employee_id) REFERENCES Employees(id)
);

CREATE TABLE order_items
(
	order_id INT NOT NULL,
	item_id INT NOT NULL,
	quantity INT NOT NULL,

	CONSTRAINT FOREIGN KEY(order_id) REFERENCES orders(id),
    CONSTRAINT FOREIGN KEY(item_id) REFERENCES items(id),
	CONSTRAINT PK_order_items PRIMARY KEY (order_id, item_id)
);

CREATE TABLE shifts
(
	id INT AUTO_INCREMENT,
	employee_id INT  NOT NULL,
	check_in DATETIME NOT NULL,
	check_out DATETIME NOT NULL,

	CONSTRAINT FOREIGN KEY(employee_id) REFERENCES employees(id),
	CONSTRAINT PK_shifts PRIMARY KEY (id, employee_id)
);
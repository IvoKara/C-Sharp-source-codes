CREATE TABLE IF NOT EXISTS clients (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(30) NOT NULL,
    last_name VARCHAR(30) NOT NULL,
    gender CHAR(1),
    birth_date DATETIME,
    credit_card VARCHAR(30) NOT NULL,
    card_validity DATETIME,
    email VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS towns (
    id INT AUTO_INCREMENT primary key,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS offices (
    id INT AUTO_INCREMENT primary key,
    name VARCHAR(40),
    parking_places INT,
    town_id INT NOT NULL,
    FOREIGN KEY (town_id)
        REFERENCES towns (id)
);

CREATE TABLE IF NOT EXISTS models (
    id INT AUTO_INCREMENT primary key,
    manufacturer VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    production_year DATETIME,
    seats INT,
    class VARCHAR(10),
    consumption decimal(14 , 2 )
);

CREATE TABLE IF NOT EXISTS vehicles (
    id INT AUTO_INCREMENT primary key,
    model_id INT NOT NULL,
    office_id INT NOT NULL,
    mileage INT,
    FOREIGN KEY (model_id)
        REFERENCES models (id),
    FOREIGN KEY (office_id)
        REFERENCES offices (id)
);

CREATE TABLE IF NOT EXISTS orders (
    id INT AUTO_INCREMENT PRIMARY KEY,
    client_id INT NOT NULL,
    town_id INT NOT NULL,
    vehicle_id INT NOT NULL,
    collection_date DATETIME NOT NULL,
    collection_office_id INT NOT NULL,
    return_date DATETIME,
    return_office_id INT,
    bill decimal(14 , 2 ),
    total_mileage INT,
    FOREIGN KEY (client_id)
        REFERENCES clients (id),
    FOREIGN KEY (town_id)
        REFERENCES towns (id),
    FOREIGN KEY (vehicle_id)
        REFERENCES vehicles (id),
    FOREIGN KEY (collection_office_id)
        REFERENCES offices (id),
    FOREIGN KEY (return_office_id)
        REFERENCES offices (id)
);

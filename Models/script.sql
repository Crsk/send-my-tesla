DROP DATABASE mytesla;
CREATE DATABASE mytesla
CHARACTER SET utf8 COLLATE utf8_general_ci;
USE mytesla;

CREATE TABLE `clients` (    
    `id` INT PRIMARY KEY AUTO_INCREMENT,
    `name` VARCHAR(45) NOT NULL DEFAULT '',
    `phone_number` VARCHAR(20) NOT NULL DEFAULT '',
    `email` VARCHAR(100) NOT NULL DEFAULT ''
);

CREATE TABLE `cars` (
    `id` INT PRIMARY KEY AUTO_INCREMENT,
    `model` VARCHAR(15) NOT NULL DEFAULT '',
    `base_price` INT DEFAULT 0,
    `image` varchar(100) NOT NULL DEFAULT '',
    `index` INT NOT NULL DEFAULT '0'
);

CREATE TABLE `dispatches` (
    `id` INT PRIMARY KEY AUTO_INCREMENT,
    `client_id` INT NULL,
    `dispatch_address` VARCHAR(400),
    FOREIGN KEY (`client_id`)
    REFERENCES `clients` (`id`)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE `orders` (
    `id` INT PRIMARY KEY AUTO_INCREMENT,
    `car_id` INT NULL,
    `dispatch_id` INT NULL,
    `date` DATETIME NULL,
    FOREIGN KEY (`car_id`)
    REFERENCES `cars` (`id`)
    ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (`dispatch_id`)
    REFERENCES `dispatches` (`id`)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE `options` (
    `id` INT PRIMARY KEY AUTO_INCREMENT,
    `code` VARCHAR(20) UNIQUE NOT NULL,
    `price` DECIMAL(8,2) NOT NULL DEFAULT 0,
    `description` VARCHAR(300) NOT NULL DEFAULT '',
    `image` VARCHAR(100) NOT NULL DEFAULT ''
);

CREATE TABLE `parts` (
    `id` INT PRIMARY KEY AUTO_INCREMENT,
    `order_id` INT NULL,
    `option_id` INT NULL,
    FOREIGN KEY (`order_id`)
    REFERENCES `orders` (`id`)
    ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (`option_id`)
    REFERENCES `options` (`id`)
    ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO `cars` VALUES (NULL, 'Model S', 75000, 'model-S.png', 1);
INSERT INTO `cars` VALUES (NULL, 'Model 3', 90000, 'model-3.png', 2);
INSERT INTO `cars` VALUES (NULL, 'Model X', 13500, 'model-x.png', 3);
INSERT INTO `cars` VALUES (NULL, 'Roadster', 220000, 'roadster.png', 4);

INSERT INTO `clients` VALUES (NULL, 'Christopher Kiessling', '+56 9 95839789', 'crsk@mail.com');
INSERT INTO `clients` VALUES (NULL, 'Denisse Leiva', '+54 9 6394573823', 'dleiva03@gmail.com');

INSERT INTO `options` VALUES (NULL, 'ext01', 2500, 'White Exterior', 'ext01.png');
INSERT INTO `options` VALUES (NULL, 'ext02', 2800, 'Black Exterior', 'ext02.png');
INSERT INTO `options` VALUES (NULL, 'ext03', 3000, 'Red Exterior', 'ext03.png');
INSERT INTO `options` VALUES (NULL, 'ext04', 5000, 'Yellow Exterior', 'ext04.png');
INSERT INTO `options` VALUES (NULL, 'whe01', 2500, 'White Wheels', 'whe01.png');
INSERT INTO `options` VALUES (NULL, 'whe02', 2800, 'Black Wheels', 'whe02.png');
INSERT INTO `options` VALUES (NULL, 'whe03', 3000, 'Red Wheels', 'whe03.png');
INSERT INTO `options` VALUES (NULL, 'whe04', 5000, 'Yellow Wheels', 'whe04.png');

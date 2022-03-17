/*
 Navicat Premium Data Transfer

 Source Server         : 123
 Source Server Type    : MySQL
 Source Server Version : 100419
 Source Host           : localhost:3306
 Source Schema         : mediartdemo

 Target Server Type    : MySQL
 Target Server Version : 100419
 File Encoding         : 65001

 Date: 17/03/2022 17:54:58
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for person
-- ----------------------------
DROP TABLE IF EXISTS `person`;
CREATE TABLE `person`  (
  `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `LastName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of person
-- ----------------------------
INSERT INTO `person` VALUES (1, 'Jose', 'Rizal');
INSERT INTO `person` VALUES (2, 'Andress', 'Bonifacio');
INSERT INTO `person` VALUES (3, 'Apolinario', 'Mabini');
INSERT INTO `person` VALUES (4, 'Bongbong', 'Marcos');
INSERT INTO `person` VALUES (5, 'Leni', 'Robredo');
INSERT INTO `person` VALUES (6, 'Ping', 'Lacson');
INSERT INTO `person` VALUES (7, ' Manny', 'Paquiao');

SET FOREIGN_KEY_CHECKS = 1;

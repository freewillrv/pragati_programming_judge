# --------------------------------------------------------
# Host:                         127.0.0.1
# Database:                     pragati_rahul
# Server version:               5.1.45-community
# Server OS:                    Win32
# HeidiSQL version:             5.0.0.3272
# Date/time:                    2011-03-19 20:24:03
# --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
# Dumping database structure for pragati_rahul
CREATE DATABASE IF NOT EXISTS `pragati_rahul` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `pragati_rahul`;


# Dumping structure for table pragati_rahul.t_msg
CREATE TABLE IF NOT EXISTS `t_msg` (
  `msg_id` int(11) NOT NULL AUTO_INCREMENT,
  `msg_fromid` int(11) DEFAULT NULL,
  `msg_toid` int(11) DEFAULT NULL,
  `msg_text` varchar(400) DEFAULT NULL,
  `msg_read` int(1) DEFAULT NULL,
  PRIMARY KEY (`msg_id`),
  KEY `FK_MSG_FROMID` (`msg_fromid`),
  KEY `FK_MSG_TOID` (`msg_toid`),
  CONSTRAINT `FK_MSG_FROMID` FOREIGN KEY (`msg_fromid`) REFERENCES `t_team` (`team_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_MSG_TOID` FOREIGN KEY (`msg_toid`) REFERENCES `t_team` (`team_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

# Dumping data for table pragati_rahul.t_msg: 1 rows
/*!40000 ALTER TABLE `t_msg` DISABLE KEYS */;
REPLACE INTO `t_msg` (`msg_id`, `msg_fromid`, `msg_toid`, `msg_text`, `msg_read`) VALUES (1, 2, 1, 'Hi boss\r\n\r\nKemon acho ??\r\n', 1);
/*!40000 ALTER TABLE `t_msg` ENABLE KEYS */;


# Dumping structure for table pragati_rahul.t_problems
CREATE TABLE IF NOT EXISTS `t_problems` (
  `problems_id` int(11) NOT NULL AUTO_INCREMENT,
  `problems_name` varchar(45) DEFAULT NULL,
  `problems_marks` int(10) unsigned DEFAULT NULL,
  `problems_input` varchar(3000) DEFAULT NULL,
  `problems_output` varchar(3000) DEFAULT NULL,
  `problems_description` text,
  PRIMARY KEY (`problems_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

# Dumping data for table pragati_rahul.t_problems: 5 rows
/*!40000 ALTER TABLE `t_problems` DISABLE KEYS */;
REPLACE INTO `t_problems` (`problems_id`, `problems_name`, `problems_marks`, `problems_input`, `problems_output`, `problems_description`) VALUES (1, 'Feynman', 100, '2\r\n1\r\n8\r\n0', '5\r\n1\r\n204\r\n', 'asd'), (2, 'Harry', 150, '1\r\n2', '1\r\n2', 'Harry Potter problem..'), (3, 'Addrev', 100, '4\r\n24 1\r\n4358 754\r\n305 794\r\n12000 13', '34\r\n1998\r\n1\r\n25', 'Adding Reversed Numbers\r\nThe Antique Comedians of Malidinesia prefer comedies to tragedies. Unfortunately, most of the ancient plays are tragedies. Therefore the dramatic advisor of ACM has decided to transfigure some tragedies into comedies. Obviously, this work is very hard because the basic sense of the play must be kept intact, although all the things change to their opposites. For example the numbers: if any number appears in the tragedy, it must be converted to its reversed form before being accepted into the comedy play. \r\nReversed number is a number written in arabic numerals but the order of digits is reversed. The first digit becomes last and vice versa. For example, if the main hero had 1245 strawberries in the tragedy, he has 5421 of them now. Note that all the leading zeros are omitted. That means if the number ends with a zero, the zero is lost by reversing (e.g. 1200 gives 21). Also note that the reversed number never has any trailing zeros. \r\nACM needs to calculate with reversed numbers. Your task is to add two reversed numbers and output their reversed sum. Of course, the result is not unique because any particular number is a reversed form of several numbers (e.g. 21 could be 12, 120 or 1200 before reversing). Thus we must assume that no zeros were lost by reversing (e.g. assume that the original number was 12). \r\nInput\r\nThe input consists of N cases (equal to about 10000). The first line of the input contains only positive integer N. Then follow the cases. Each case consists of exactly one line with two positive integers separated by space. These are the reversed numbers you are to add. \r\nOutput\r\nFor each case, print exactly one line containing only one integer - the reversed sum of two reversed numbers. Omit any leading zeros in the output. \r\nExample\r\nSample input: \r\n\r\n3\r\n24 1\r\n4358 754\r\n305 794\r\n\r\nSample output:\r\n\r\n34\r\n1998\r\n'), (4, 'Simple', 20, '3\r\n1\r\n2\r\n3', '1\r\n2\r\n3\r\n', 't7ut7u'), (5, 'Candy', 100, '5\r\n1\r\n1\r\n1\r\n1\r\n6\r\n2\r\n3\r\n4\r\n-1', '4\r\n-1', 'Jennifer is a teacher in the first year of a primary school. She has gone for a trip with her class today. She has taken a packet of candies for each child. Unfortunatelly, the sizes of the packets are not the same.\r\n\r\nJennifer is afraid that each child will want to have the biggest packet of candies and this will lead to quarrels or even fights among children. She wants to avoid this. Therefore, she has decided to open all the packets, count the candies in each packet and move some candies from bigger packets to smaller ones so that each packet will contain the same number of candies. The question is how many candies she has to move.\r\nInput specification\r\n\r\nThe input file consists of several blocks of data. Each block starts with the number of candy packets N(1<= N <=10000) followed by N integers (each less than 1000) in separate lines, giving the number of candies in each packet. After the last block of data there is the number -1.\r\nOutput specification\r\n\r\nThe output file should contain one line with the smallest number of moves for each block of data. One move consists of taking one candy from a packet and putting it into another one. If it is not possible to have the same number of candies in each packet, output the number -1.\r\nExample\r\n\r\nInput file:\r\n5\r\n1\r\n1\r\n1\r\n1\r\n6\r\n2\r\n3\r\n4\r\n-1\r\n\r\nOutput file:\r\n4\r\n-1\r\n');
/*!40000 ALTER TABLE `t_problems` ENABLE KEYS */;


# Dumping structure for table pragati_rahul.t_submission
CREATE TABLE IF NOT EXISTS `t_submission` (
  `sub_id` int(20) NOT NULL AUTO_INCREMENT,
  `sub_teamid` int(11) NOT NULL DEFAULT '0',
  `sub_probid` int(11) NOT NULL DEFAULT '0',
  `sub_time` varchar(45) DEFAULT NULL,
  `sub_no_of_errors` int(11) DEFAULT NULL,
  PRIMARY KEY (`sub_id`),
  KEY `FK_PROB_ID` (`sub_probid`),
  KEY `FK_TEAM_ID` (`sub_teamid`),
  CONSTRAINT `FK_PROB_ID` FOREIGN KEY (`sub_probid`) REFERENCES `t_problems` (`problems_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_TEAM_ID` FOREIGN KEY (`sub_teamid`) REFERENCES `t_team` (`team_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

# Dumping data for table pragati_rahul.t_submission: 0 rows
/*!40000 ALTER TABLE `t_submission` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_submission` ENABLE KEYS */;


# Dumping structure for table pragati_rahul.t_team
CREATE TABLE IF NOT EXISTS `t_team` (
  `team_id` int(11) NOT NULL AUTO_INCREMENT,
  `team_login` varchar(45) DEFAULT NULL,
  `team_pass` varchar(45) DEFAULT 'nopass',
  `team_score` int(5) DEFAULT '100',
  PRIMARY KEY (`team_id`),
  UNIQUE KEY `team_login_UNIQUE` (`team_login`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

# Dumping data for table pragati_rahul.t_team: 3 rows
/*!40000 ALTER TABLE `t_team` DISABLE KEYS */;
REPLACE INTO `t_team` (`team_id`, `team_login`, `team_pass`, `team_score`) VALUES (1, 'Pragati', 'vabtethak', 0), (2, 'Alpha', '420', 100), (3, 'Delta', '123', 100);
/*!40000 ALTER TABLE `t_team` ENABLE KEYS */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

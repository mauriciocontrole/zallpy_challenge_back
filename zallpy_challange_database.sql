CREATE DATABASE question_form;

USE question_form;

CREATE TABLE questions(Id INT NOT NULL, QuestionBody VARCHAR(100) NOT NULL, AnswerCorrect CHAR(2) NOT NULL, PRIMARY KEY(Id));

INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (1, 'Qual é a origem da BMW?', 'A3');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (2, 'Qual é a origem da Toyota?', 'A4');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (3, 'Qual é a origem da Mini?', 'A1');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (4, 'Qual é a origem da General Motors?', 'A2');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (5, 'Qual é a origem da Rolls-Royce?', 'A1');

SELECT * FROM questions;
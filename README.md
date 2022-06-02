# GameUlearn
Викторина на знание литературы, реализованная в Windows Forms
Идея:
Герой попадает в волшебный мир, выбраться из которого можно только правильно отвечая на вопросы по художественной литературе.
Идея волшебного мира заключается в том, что мы попадаем в общество великих авторов, поэтов и писателей мировой литературы. 
Вопросы будут делиться на три уровня сложности. За правильный ответ игрок будет получать определённое количество баллов 
(лёгкий вопрос - 5 баллов, средний - 10, сложный - 20), за ошибку это же количество баллов будет вычитаться. 
Количество вопросов ограничено, поэтому по окончании всех вопросов игрок увидит свой результат и самый лучший результат за все игры. 
Цель - стремиться к тому, чтобы улучшать результат и достичь максимального.
Дизайн:
На фоне будут картинки обстановки литературных салонов, городских улиц и садов.
Также будет выбран один писатель для роли «ведущего» викторины на каждом уровне. В процессе игры его картинка будет находиться на экране.
Сами же вопросы будут по центру экрана.
Геймплей:
Начинаться игра будет с нажатия кнопки, после чего появится окно, сообщающее о начале первого уровня. 
После того, как пользователь щёлкнет мышкой в любом месте на экране окно с текстом закроется, 
но тут же отобразится другое окно с текстом вопроса и четырьмя вариантами ответа. 
Так будет продолжаться до момента окончания первого уровня, после чего игрок увидит сообщение о начале второго уровня, 
после чего игра будет проходить аналогично первому уровню. Тоже самое будет и на третьем уровне.
После чего на экран выведется настоящий результат игрока и лучший результат.

Классы, необходимые для реализации:
1)класс начального окна
2)классы игровых зоны (в которых прорабатывается весь ход игры)
3)класс вопросов и ответов

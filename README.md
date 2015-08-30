# TestTask3
Test task3 for programming classes
Приложение "Calendar".
Приложение отображает события, время окончания которых сегодня или позже, таким образом пользователь может видеть те события,
которые начались в прошлом но продолжаются и до сегодня.

Приложение позволят создавать новые, редактировать и удалять существующие события.
Все описанные ниже изменения делаются локально. Для того, что бы они были сохранены в файл, необходимо после проведенных изменений
нажать на кнопку "Save".

Для того, что бы создать новое событие нужно:
- Заполнить поля входящие в группу полей "Create/Modify".
- Нажать кнопку "Create".
- Если создаваемое событие не прошло валидацию, необходимо подкорректировать введенные данные.
- После прохождения валидации созданное событие отобразится в поле "Events".

Для того, что бы изменить существующее событие нужно:
- Заполнить поля входящие в группу полей "Create/Modify".
- Выбрать в поле "Events"событие, которое нужно изменить.
- Нажать кнопку "Modify". 
- Если изменяемое событие не прошло валидацию, необходимо подкорректировать введенные данные.
- После прохождения валидации изменения в событии отобразятся в поле "Events".

Для того, что бы удалить существующее событие нужно:
- Выбрать в поле "Events"событие, которое нужно удалить.
- Нажать кнопку "Delete".
- Событие будет удалено из списка отображаемых событий в поле "Events".

Валидации.
Любое создаваемое или изменяемое событие должно пройти валидацию, прежде чем оно попадет в список отображаеммых событий.
Система выполняет следующие валидации:
- Название события вводимое в поле "Name" не должно превышать 50 символов.
- Нельзя создать событие с пустым названием.
- Время окончания события не может быть раньше чем время начала события.
- Нельзя созать событие, время начала которого ранее чем сегодня.
- Если создаваемое или модифицируемое событие накладывается по времени на уже существующие события, система уведомит об этом пользователя и спросит, хочет ли он
продолжить сохранение события.

Хранение событий.
Данные о событиях храняться в текстовом файле(расширение .txt) по имени Calendar, который должен размещаться в папке bin/Debug.
Если указанный файл отсутствует, система создаст необходимый пустой файл.

Формат хранения данных в текстовом файле следующий:
Имя события%дата/время начала%дата/время окончания
в качестве сепаратора между составляющими данных о событии используется символ процента

Время/дата хранится в следующем формате:
dd-MM-yyyy HH:mm
Символ пробела между датой и временем обязателен

Таким образом запись о событии выглядит:
Имя события%dd-MM-yyyy HH:mm%dd-MM-yyyy HH:mm

Каждое событие должно быть записано в новом рядке файла.
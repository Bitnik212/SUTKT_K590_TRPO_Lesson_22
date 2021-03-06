# ПРАКТИКУМ 2. КОНТЕЙНЕРЫ КОМПОНОВКИ
Цель: формирование навыка работы с элементами компоновки при разработке графического интерфейса пользователя на основе технологии WPF.

# Задания для самостоятельного выполнения:
Решите предоставленные задания. Все задания необходимо выполнить в отдельных проектах, используя элементы компоновки. Продемонстрируйте выполненные работы преподавателю.
- [x] Вариант 1. Введите с клавиатуры двузначное число. Является ли оно кратным 3? Является ли оно четным или нечетным? Рассчитайте сумму и произведение цифр. Результаты выведите на экран.
- [x] Вариант 2. Создайте окно при изменении, размера которого, элементы, находящиеся внутри динамически перестраивались.
- [x] Вариант 3. Создайте меню со стандартным размещением вверху окна, в качестве элементов меню используйте Label или TextBlock, TextBox, в основной части окна размещается TextBox в который можно вводить текст, а также имеется кнопка, нажав по которой содержимое TextBox очищается. Контент окна должен перестраиваться при изменении размеров окна.
- [x] Вариант 4. Создайте приложение, в котором есть несколько режимов работы, в первом вы можете рисовать, а во втором стирать нарисованное.

## Теория

В WPF компоновка осуществляется при помощи специальных контейнеров. Фреймворк предоставляет нам следующие контейнеры: 
- **Grid**, 
- **UniformGrid**, 
- **StackPanel**, 
- **WrapPanel**, 
- **DockPanel**,
- **Canvas**

Контейнеры компоновки позволяют эффективно распределить доступное пространство между элементами, найти для него наиболее предпочтительные размеры.

### Canvas

Элемент управления Canvas поддерживает абсолютное позиционирование и предоставляет минимум встроенных возможностей макета для содержащихся в нем элементов управления. Элемент управления Canvas позволяет размещать содержащиеся в нем элементы управления со сдвигом относительно любого угла панели. 
Canvas предоставляет четыре свойства для содержащихся в нем элементов управления: **Top, Bottom, Right и Left**. 
Элементы управления, содержащиеся в элементе управления Canvas, должны определять одно свойство по горизонтали и одно свойство по вертикали, тем самым назначая угол, от которого будет задаваться смещение.

### DockPanel

Элемент управления DockPanel обеспечивает поддержку закрепления для упрощения расположения панелей инструментов и других элементов управления, которые требуется закрепить вдоль одной из границ панели.
Элемент управления DockPanel предоставляет свойство с именем DockStyle для содержащихся в нем элементов управления, которое определяет, как они будут расположены.

### Grid

Наиболее знакомым контейнерным элементом управления является элемент управления Grid. По умолчанию каждое новое окно Window, открытое в Windows Presentation Foundation (WPF) для Visual Studio (конструктор), включает элемент управления Grid. Элемент управления Grid позволяет позиционировать элементы управления внутри ячеек, задаваемых пользователем. 
Элементы управления, помещенные в ячейки, поддерживают фиксированное поле между двумя или более краями элемента управления и краями ячеек при изменении размера окна Window.

### StackPanel

Элемент управления StackPanel располагает содержащиеся в нем элементы управления либо в вертикальном столбце, либо в горизонтальной строке, в зависимости от значения свойства Orientation. Если в элемент управления StackPanel добавлено больше элементов управления, чем может быть отображено по ширине StackPanel, лишние элементы обрезаются и не отображаются. Значение по умолчанию является растягиванием и для HorizontalAlignment, и для VerticalAlignment содержимого, содержащегося в StackPanel.

### WrapPanel

Элемент управления WrapPanel аналогичен элементу управления StackPanel в том, что в нем элементы управления располагаются в столбце или в строке в зависимости от свойства Orientation. В дополнение к подобному расположению, элемент управления WrapPanel поддерживает возможность переноса в следующий столбец или строку для содержащихся в нем элементов управления. 

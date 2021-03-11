using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreetObjects.Properties;

namespace StreetObjects
{
    public partial class Test1 : Form
    {
        int pictureNumber = 0;
        int time = 0;
        int timerValue = 30;
        public int rightAnswer = 0;
        public int mistakes = 0;
        int answers = 0;
        List<string> log = new List<string> { };
        Random random = new Random();

        static Color blue = new Color { name = "Синий" };
        static Color red = new Color { name = "Красный" };
        static Color violet = new Color { name = "Фиолетовый" };
        static Color green = new Color { name = "Зелёный" };
        static Color olive = new Color { name = "Оливковый" };
        static Color white = new Color { name = "Белый" };
        static Color yellow = new Color { name = "Жёлтый" };
        static Color black = new Color { name = "Чёрный" };
        static Color pink = new Color { name = "Розовый" };
        static Color grey = new Color { name = "Серый" };

        static Color none = new Color { name = "Выключен" };

        List<Color> trafficLightColors = new List<Color> { red, green, none };

        static CarType sedan = new CarType { name = "Седан" };
        static CarType hatchback = new CarType { name = "Хэтчбек" };
        static CarType bus = new CarType { name = "Автобус" };
        static CarType sport = new CarType { name = "Спорткар" };

        static Road crossroad = new Road { name = "Да" };
        static Road fourStripes = new Road { name = "Нет" };

        List<Road> roads = new List<Road> { crossroad, fourStripes };

        static Car blueSedan = new Car { color = blue, type = sedan };
        static Car violerHatchback = new Car { color = violet, type = hatchback };
        static Car oliveHatchback = new Car { color = olive, type = hatchback };
        static Car whiteBus = new Car { color = white, type = bus };
        static Car yellowSport = new Car { color = yellow, type = sport };
        static Car greenSport = new Car { color = green, type = sport };
        static Car redSport = new Car { color = red, type = sport };
        static Car whiteSedan = new Car { color = white, type = sedan };
        static Car blackHatchback = new Car { color = black, type = hatchback };
        static Car pinkHatchback = new Car { color = pink, type = hatchback };
        static Car greyHatchback = new Car { color = grey, type = hatchback };
        static Car greySedan = new Car { color = grey, type = sedan };
        static Car redSedan = new Car { color = red, type = sedan };
        static Car greenSedan = new Car { color = green, type = sedan };
        static Car yellowHatchback = new Car { color = yellow, type = hatchback };
        static Car redBus = new Car { color = red, type = bus };
        static Car yellowBus = new Car { color = yellow, type = bus };

        List<Car> cars = new List<Car> { blueSedan, violerHatchback, oliveHatchback, whiteBus, yellowSport, greenSport, redSport, whiteSedan, blackHatchback, 
                                         pinkHatchback, greyHatchback, greySedan, redSedan, greenSedan, yellowHatchback, redBus, yellowBus };

        static Sign priorityRoad = new Sign { name = "Главная дорога" };
        static Sign directionOfPriorityRoad = new Sign { name = "Направление главной дороги" };
        static Sign yield = new Sign { name = "Уступите дорогу" };
        static Sign obstacle = new Sign { name = "Препятствие" };
        static Sign keepRight = new Sign {name = "Объезд препятствия справа" };
        static Sign pedestrianCrossing = new Sign { name = "Пешеходный переход" };

        List<Sign> signs = new List<Sign> { priorityRoad, directionOfPriorityRoad, yield, obstacle, keepRight, pedestrianCrossing };

        Picture[] picture = new Picture[18];
        Question[] question = new Question[10];

        public Test1(int timerValue)
        {
            InitializeComponent();

            this.timerValue = timerValue;
            timer.Enabled = true;
            pictureNumber = random.Next(0, 18);

            picture[0] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._1, trafficLight = true, trafficLightColor = green };
            picture[0].car.Add(blueSedan);

            picture[1] = new Picture { trafficCop = false, people = 4, road = crossroad, picture = Resources._2, trafficLight = false };
            picture[1].car.Add(blueSedan);
            picture[1].car.Add(violerHatchback);
            picture[1].sign.Add(priorityRoad);
            picture[1].sign.Add(directionOfPriorityRoad);

            picture[2] = new Picture { trafficCop = false, people = 2, road = crossroad, picture = Resources._3, trafficLight = false };
            picture[2].car.Add(blueSedan);
            picture[2].car.Add(whiteBus);
            picture[2].car.Add(oliveHatchback);
            picture[2].sign.Add(priorityRoad);

            picture[3] = new Picture { trafficCop = false, people = 1, road = crossroad, picture = Resources._4, trafficLight = false };
            picture[3].car.Add(blueSedan);
            picture[3].sign.Add(yield);

            picture[4] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._5, trafficLight = false };
            picture[4].car.Add(blueSedan);
            picture[4].car.Add(redSport);
            picture[4].car.Add(greenSport);
            picture[4].car.Add(yellowSport);
            picture[4].sign.Add(priorityRoad);
            picture[4].sign.Add(directionOfPriorityRoad);

            picture[5] = new Picture { trafficCop = false, people = 3, road = crossroad, picture = Resources._6, trafficLight = false };
            picture[5].car.Add(whiteSedan);
            picture[5].car.Add(blackHatchback);
            picture[5].sign.Add(directionOfPriorityRoad);
            picture[5].sign.Add(yield);

            picture[6] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._7, trafficLight = true, trafficLightColor = green };

            picture[7] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._8, trafficLight = false };
            picture[7].car.Add(blueSedan);
            picture[7].car.Add(redSport);
            picture[7].sign.Add(priorityRoad);
            picture[7].sign.Add(directionOfPriorityRoad);

            picture[8] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._9, trafficLight = true, trafficLightColor = red };
            picture[8].car.Add(blueSedan);
            picture[8].car.Add(pinkHatchback);
            picture[8].car.Add(greenSport);

            picture[9] = new Picture { trafficCop = true, people = 1, road = crossroad, picture = Resources._10, trafficLight = false };
            picture[9].car.Add(greyHatchback);

            picture[10] = new Picture { trafficCop = false, people = 2, road = crossroad, picture = Resources._11, trafficLight = true, trafficLightColor = green };
            picture[10].car.Add(greySedan);
            picture[10].car.Add(yellowHatchback);
            picture[10].car.Add(redSedan);
            picture[10].car.Add(greenSedan);

            picture[11] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._12, trafficLight = true, trafficLightColor = green };
            picture[11].car.Add(blueSedan);
            picture[11].car.Add(redSport);
            picture[11].car.Add(greenSport);

            picture[12] = new Picture { trafficCop = false, people = 0, road = fourStripes, picture = Resources._13, trafficLight = false };
            picture[12].car.Add(redBus);
            picture[12].car.Add(yellowBus);
            picture[12].car.Add(greySedan);
            picture[12].car.Add(greyHatchback);
            picture[12].sign.Add(obstacle);
            picture[12].sign.Add(pedestrianCrossing);
            picture[12].sign.Add(keepRight);

            picture[13] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._14, trafficLight = false };
            picture[13].car.Add(blueSedan);

            picture[14] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._15, trafficLight = true, trafficLightColor = green };
            picture[14].car.Add(blueSedan);

            picture[15] = new Picture { trafficCop = false, people = 0, road = crossroad, picture = Resources._16, trafficLight = false };
            picture[15].car.Add(blueSedan);
            picture[15].car.Add(yellowSport);
            picture[15].car.Add(redSport);
            picture[15].sign.Add(priorityRoad);
            picture[15].sign.Add(directionOfPriorityRoad);

            picture[16] = new Picture { trafficCop = false, people = 3, road = crossroad, picture = Resources._17, trafficLight = true, trafficLightColor = red };
            picture[16].car.Add(pinkHatchback);
            picture[16].car.Add(blueSedan);
            picture[16].car.Add(greenSport);

            picture[17] = new Picture { trafficCop = false, people = 2, road = crossroad, picture = Resources._18, trafficLight = false };
            picture[17].car.Add(redSedan);
            picture[17].car.Add(redSport);

            #region "Вопросы"

            question[0] = new Question { question = "Был ли регулировщик?" };
            question[0].variants.Add("Да");
            question[0].variants.Add("Нет");
            if (picture[pictureNumber].trafficCop)
            {
                question[0].rightAnswer.Add("Да");
            }
            else
            {
                question[0].rightAnswer.Add("Нет");
            }

            question[1] = new Question { question = "Сколько было пешеходов?" };
            for (int i = 0; i < 6; i++)
            {
                question[1].variants.Add(i.ToString());
            }
            question[1].rightAnswer.Add(picture[pictureNumber].people.ToString());

            question[2] = new Question { question = "Это был перекрёсток?" };
            foreach (var item in roads)
            {
                question[2].variants.Add(item.name);
            }
            question[2].rightAnswer.Add(picture[pictureNumber].road.name);

            question[3] = new Question { question = "Был ли светофор?" };
            question[3].variants.Add("Да");
            question[3].variants.Add("Нет");
            if (picture[pictureNumber].trafficLight)
            {
                question[3].rightAnswer.Add("Да");
            }
            else
            {
                question[3].rightAnswer.Add("Нет");
            }

            if (picture[pictureNumber].trafficLightColor != null)
            {
                question[4] = new Question { question = "Какого цвета был сфетофор?" };
                foreach (var item in trafficLightColors)
                {
                    question[4].variants.Add(item.name);
                }
                question[4].rightAnswer.Add(picture[pictureNumber].trafficLightColor.name);
            }

            question[5] = new Question { question = "Сколько было автомобилей?" };
            for (int i = 0; i < 6; i++)
            {
                question[5].variants.Add(i.ToString());
            }
            question[5].rightAnswer.Add(picture[pictureNumber].car.Count.ToString());

            if (picture[pictureNumber].car.Count > 0)
            {
                question[6] = new Question { question = "Какой автомобиль был на картинке?" };
                foreach (var item in cars)
                {
                    question[6].variants.Add(item.Name());
                }
                foreach (var item in picture[pictureNumber].car)
                {
                    question[6].rightAnswer.Add(item.Name());
                }
            }

            question[7] = new Question { question = "Сколько было знаков на вашей полосе?" };
            for (int i = 0; i < 6; i++)
            {
                question[7].variants.Add(i.ToString());
            }
            question[7].rightAnswer.Add(picture[pictureNumber].sign.Count.ToString());

            if (picture[pictureNumber].sign.Count > 0)
            {
                question[8] = new Question { question = "Какие знаки были на вашей полосе?" };
                foreach (var item in signs)
                {
                    question[8].variants.Add(item.name);
                }
                foreach (var item in picture[pictureNumber].sign)
                {
                    question[8].rightAnswer.Add(item.name);
                }
            }

            #endregion

            pictureBox.Image = picture[pictureNumber].picture;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (answers > 0 && question[answers] != null)
            {
                if (question[answers].rightAnswer.Contains(comboBox.SelectedItem))
                {
                    rightAnswer++;
                    question[answers].rightAnswer.Remove(comboBox.SelectedItem.ToString());
                    log.Add("Верно: " + comboBox.SelectedItem.ToString() + " - " + question[answers].question);
                    comboBox.Items.Remove(comboBox.SelectedItem);
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    mistakes++;
                    question[answers].rightAnswer.Clear();
                    log.Add("Ошибка: " + comboBox.SelectedItem.ToString() + " - " + question[answers].question);
                }
            }

            if (answers < 1)
            {
                answers++;
            }
            else
            {
                if (question[answers] != null)
                {
                    if (question[answers].rightAnswer.Count == 0)
                    {
                        answers++;
                    }
                }
            }

            if (answers < 9)
            {
                if (question[answers] != null)
                {
                    if (question[answers].question != textBox.Text)
                    {
                        textBox.Text = question[answers].question;
                        comboBox.Items.Clear();
                        foreach (var item in question[answers].variants)
                        {
                            comboBox.Items.Add(item);
                        }
                        comboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    answers++;
                    if (question[answers] != null)
                    {
                        textBox.Text = question[answers].question;
                        comboBox.Items.Clear();
                        foreach (var item in question[answers].variants)
                        {
                            comboBox.Items.Add(item);
                        }
                    }
                    comboBox.SelectedIndex = 0;
                    if (answers>8)
                    {
                        okButton_Click(sender, e);
                    }
                }
            }
            else
            {
                textBox.Text = "Правильных ответов: " + rightAnswer.ToString() + " | Ошибок: " + mistakes.ToString();
                comboBox.Items.Clear();
                foreach (var item in log)
                {
                    comboBox.Items.Add(item);
                }
                comboBox.SelectedIndex = 0;
                okButton.Visible = false;
                cancel.Visible = true;
                pictureBox.Visible = true;
                hideButton.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > timerValue)
            {
                timer.Enabled = false;
                time = 0;
                okButton.Visible = true;
                comboBox.Visible = true;
                textBox.Visible = true;
                pictureBox.Visible = false;

                answers = -1;

                okButton_Click(sender, e);
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            cancel.Visible = !cancel.Visible;
            textBox.Visible = !textBox.Visible;
            comboBox.Visible = !comboBox.Visible;
            if (hideButton.Text == "Показать")
            {
                hideButton.Text = "Скрыть";
            }
            else
            {
                hideButton.Text = "Показать";
            }
        }
    }
}

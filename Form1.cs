﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceRotas_AG
{
    public partial class Rotas : Form
    {

        public Rotas()
        {
            InitializeComponent();
        }
        private static int x = 38;
        private static int y = 38;
        Graphics desenhador;
        static private Bitmap img;
        static Rectangle rect = new Rectangle(x, y, 120, 120);
        static Rectangle rect1 = new Rectangle(x, rect.Y + rect.Height + y, 120, 120);
        static Rectangle rect2 = new Rectangle(x, rect1.Y + rect.Height + y, 120, 120);
        static Rectangle rect3 = new Rectangle(x, rect2.Y + rect.Height + y, 120, 120);
        static Rectangle rect4 = new Rectangle(rect.X + rect.Width + x, y, 120, 120);
        static Rectangle rect5 = new Rectangle(rect4.X + rect.Width + x, y, 120, 120);
        static Rectangle rect6 = new Rectangle(rect5.X + rect.Width + x, y, 120, 120);
        static Rectangle rect7 = new Rectangle(rect6.X + rect.Width + x, y, 120, 120);
        Rectangle rect8 = new Rectangle(rect4.X, rect1.Y, 120, 120);
        Rectangle rect9 = new Rectangle(rect5.X, rect1.Y, 120, 120);
        Rectangle rect10 = new Rectangle(rect6.X, rect1.Y, 120, 120);
        Rectangle rect11 = new Rectangle(rect7.X, rect1.Y, 120, 120);
        Rectangle rect12 = new Rectangle(rect4.X, rect2.Y, 120, 120);
        Rectangle rect13 = new Rectangle(rect5.X, rect2.Y, 120, 120);
        Rectangle rect14 = new Rectangle(rect6.X, rect2.Y, 120, 120);
        Rectangle rect15 = new Rectangle(rect7.X, rect2.Y, 120, 120);
        Rectangle rect16 = new Rectangle(rect4.X, rect3.Y, 120, 120);
        Rectangle rect17 = new Rectangle(rect5.X, rect3.Y, 120, 120);
        Rectangle rect18 = new Rectangle(rect6.X, rect3.Y, 120, 120);
        Rectangle rect19 = new Rectangle(rect7.X, rect3.Y, 120, 120);
        Rectangle cruzamento_2 = new Rectangle(rect4.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_1 = new Rectangle(rect.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_3 = new Rectangle(rect5.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_4 = new Rectangle(rect6.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_5 = new Rectangle(rect7.X - x, rect.Y - y, x, y);
        Rectangle cruzamento_6 = new Rectangle(rect7.X + rect7.Height, rect.Y - y, x, y);
        Rectangle cruzamento_7 = new Rectangle(rect.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_8 = new Rectangle(rect4.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_9 = new Rectangle(rect5.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_10 = new Rectangle(rect6.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_11 = new Rectangle(rect7.X - x, rect1.Y - y, x, y);
        Rectangle cruzamento_12 = new Rectangle(rect7.X + rect7.Height, rect1.Y - y, x, y);
        Rectangle cruzamento_13 = new Rectangle(rect.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_14 = new Rectangle(rect4.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_19 = new Rectangle(rect.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_25 = new Rectangle(rect.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_20 = new Rectangle(rect4.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_26 = new Rectangle(rect4.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_15 = new Rectangle(rect5.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_16 = new Rectangle(rect6.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_21 = new Rectangle(rect5.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_27 = new Rectangle(rect5.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_22 = new Rectangle(rect6.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_17 = new Rectangle(rect7.X - x, rect2.Y - y, x, y);
        Rectangle cruzamento_18 = new Rectangle(rect7.X + rect7.Height, rect2.Y - y, x, y);
        Rectangle cruzamento_23 = new Rectangle(rect7.X - x, rect3.Y - y, x, y);
        Rectangle cruzamento_24 = new Rectangle(rect7.X + rect7.Height, rect3.Y - y, x, y);
        Rectangle cruzamento_29 = new Rectangle(rect7.X - x, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_30 = new Rectangle(rect7.X + rect7.Height, rect3.Y + rect3.Height, x, y);
        Rectangle cruzamento_28 = new Rectangle(rect6.X - x, rect3.Y + rect3.Height, x, y);
        Brush pincelQuarterao = new SolidBrush(Color.ForestGreen);
        Brush pincel_cruzamento = new SolidBrush(Color.AntiqueWhite);
        Rectangle[] Cruzamentos = new Rectangle[30];
        Pen myPen = new System.Drawing.Pen(Color.LightYellow, 3);
        private int i = 0;
        private List<int> id = new List<int>();

        private void DesenhaQuarteroes()
        {
            desenhador.FillRectangle(pincelQuarterao, rect);
            desenhador.FillRectangle(pincelQuarterao, rect1);
            desenhador.FillRectangle(pincelQuarterao, rect2);
            desenhador.FillRectangle(pincelQuarterao, rect3);
            desenhador.FillRectangle(pincelQuarterao, rect4);
            desenhador.FillRectangle(pincelQuarterao, rect5);
            desenhador.FillRectangle(pincelQuarterao, rect6);
            desenhador.FillRectangle(pincelQuarterao, rect7);
            desenhador.FillRectangle(pincelQuarterao, rect8);
            desenhador.FillRectangle(pincelQuarterao, rect9);
            desenhador.FillRectangle(pincelQuarterao, rect10);
            desenhador.FillRectangle(pincelQuarterao, rect11);
            desenhador.FillRectangle(pincelQuarterao, rect12);
            desenhador.FillRectangle(pincelQuarterao, rect13);
            desenhador.FillRectangle(pincelQuarterao, rect14);
            desenhador.FillRectangle(pincelQuarterao, rect15);
            desenhador.FillRectangle(pincelQuarterao, rect16);
            desenhador.FillRectangle(pincelQuarterao, rect17);
            desenhador.FillRectangle(pincelQuarterao, rect18);
            desenhador.FillRectangle(pincelQuarterao, rect19);
        }

        private void DesenhaAvenidas()
        {
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_8);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_9);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_10);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_11);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_14);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_20);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_15);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_21);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_16);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_22);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_17);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_23);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_7);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_13);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_19);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_1);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_2);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_3);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_4);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_5);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_25);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_26);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_27);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_28);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_29);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_6);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_12);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_18);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_24);
            desenhador.FillRectangle(pincel_cruzamento, cruzamento_30);

        }

        private void DesenhaFaixas()
        {
            int y1 = 19, y2 = 177, y3 = 335, y4 = 493, y5 = 651, y6 = 809;

            desenhador.DrawLine(myPen, new Point(50, y1), new Point(70, 19));
            desenhador.DrawLine(myPen, new Point(75, y1), new Point(95, 19));
            desenhador.DrawLine(myPen, new Point(100, y1), new Point(120, 19));
            desenhador.DrawLine(myPen, new Point(125, y1), new Point(145, 19));

            desenhador.DrawLine(myPen, new Point(208, y1), new Point(228, 19));
            desenhador.DrawLine(myPen, new Point(233, y1), new Point(253, 19));
            desenhador.DrawLine(myPen, new Point(258, y1), new Point(278, 19));
            desenhador.DrawLine(myPen, new Point(283, y1), new Point(303, 19));

            desenhador.DrawLine(myPen, new Point(366, y1), new Point(386, 19));
            desenhador.DrawLine(myPen, new Point(391, y1), new Point(411, 19));
            desenhador.DrawLine(myPen, new Point(416, y1), new Point(436, 19));
            desenhador.DrawLine(myPen, new Point(441, y1), new Point(461, 19));

            desenhador.DrawLine(myPen, new Point(524, y1), new Point(544, 19));
            desenhador.DrawLine(myPen, new Point(549, y1), new Point(569, 19));
            desenhador.DrawLine(myPen, new Point(574, y1), new Point(594, 19));
            desenhador.DrawLine(myPen, new Point(599, y1), new Point(619, 19));

            desenhador.DrawLine(myPen, new Point(682, y1), new Point(702, 19));
            desenhador.DrawLine(myPen, new Point(707, y1), new Point(727, 19));
            desenhador.DrawLine(myPen, new Point(732, y1), new Point(752, 19));
            desenhador.DrawLine(myPen, new Point(757, y1), new Point(777, 19));

            //r2
            desenhador.DrawLine(myPen, new Point(50, y2), new Point(70, y2));
            desenhador.DrawLine(myPen, new Point(75, y2), new Point(95, y2));
            desenhador.DrawLine(myPen, new Point(100, y2), new Point(120, y2));
            desenhador.DrawLine(myPen, new Point(125, y2), new Point(145, y2));

            desenhador.DrawLine(myPen, new Point(208, y2), new Point(228, y2));
            desenhador.DrawLine(myPen, new Point(233, y2), new Point(253, y2));
            desenhador.DrawLine(myPen, new Point(258, y2), new Point(278, y2));
            desenhador.DrawLine(myPen, new Point(283, y2), new Point(303, y2));

            desenhador.DrawLine(myPen, new Point(366, y2), new Point(386, y2));
            desenhador.DrawLine(myPen, new Point(391, y2), new Point(411, y2));
            desenhador.DrawLine(myPen, new Point(416, y2), new Point(436, y2));
            desenhador.DrawLine(myPen, new Point(441, y2), new Point(461, y2));

            desenhador.DrawLine(myPen, new Point(524, y2), new Point(544, y2));
            desenhador.DrawLine(myPen, new Point(549, y2), new Point(569, y2));
            desenhador.DrawLine(myPen, new Point(574, y2), new Point(594, y2));
            desenhador.DrawLine(myPen, new Point(599, y2), new Point(619, y2));

            desenhador.DrawLine(myPen, new Point(682, y2), new Point(702, y2));
            desenhador.DrawLine(myPen, new Point(707, y2), new Point(727, y2));
            desenhador.DrawLine(myPen, new Point(732, y2), new Point(752, y2));
            desenhador.DrawLine(myPen, new Point(757, y2), new Point(777, y2));

            //r3
            desenhador.DrawLine(myPen, new Point(50, y3), new Point(70, y3));
            desenhador.DrawLine(myPen, new Point(75, y3), new Point(95, y3));
            desenhador.DrawLine(myPen, new Point(100, y3), new Point(120, y3));
            desenhador.DrawLine(myPen, new Point(125, y3), new Point(145, y3));

            desenhador.DrawLine(myPen, new Point(208, y3), new Point(228, y3));
            desenhador.DrawLine(myPen, new Point(233, y3), new Point(253, y3));
            desenhador.DrawLine(myPen, new Point(258, y3), new Point(278, y3));
            desenhador.DrawLine(myPen, new Point(283, y3), new Point(303, y3));

            desenhador.DrawLine(myPen, new Point(366, y3), new Point(386, y3));
            desenhador.DrawLine(myPen, new Point(391, y3), new Point(411, y3));
            desenhador.DrawLine(myPen, new Point(416, y3), new Point(436, y3));
            desenhador.DrawLine(myPen, new Point(441, y3), new Point(461, y3));
        
            desenhador.DrawLine(myPen, new Point(524, y3), new Point(544, y3));
            desenhador.DrawLine(myPen, new Point(549, y3), new Point(569, y3));
            desenhador.DrawLine(myPen, new Point(574, y3), new Point(594, y3));
            desenhador.DrawLine(myPen, new Point(599, y3), new Point(619, y3));

            desenhador.DrawLine(myPen, new Point(682, y3), new Point(702, y3));
            desenhador.DrawLine(myPen, new Point(707, y3), new Point(727, y3));
            desenhador.DrawLine(myPen, new Point(732, y3), new Point(752, y3));
            desenhador.DrawLine(myPen, new Point(757, y3), new Point(777, y3));

            //r4
            desenhador.DrawLine(myPen, new Point(50, y4), new Point(70, y4));
            desenhador.DrawLine(myPen, new Point(75, y4), new Point(95, y4));
            desenhador.DrawLine(myPen, new Point(100, y4), new Point(120, y4));
            desenhador.DrawLine(myPen, new Point(125, y4), new Point(145, y4));
            desenhador.DrawLine(myPen, new Point(208, y4), new Point(228, y4));
            desenhador.DrawLine(myPen, new Point(233, y4), new Point(253, y4));
            desenhador.DrawLine(myPen, new Point(258, y4), new Point(278, y4));
            desenhador.DrawLine(myPen, new Point(283, y4), new Point(303, y4));
            desenhador.DrawLine(myPen, new Point(366, y4), new Point(386, y4));
            desenhador.DrawLine(myPen, new Point(391, y4), new Point(411, y4));
            desenhador.DrawLine(myPen, new Point(416, y4), new Point(436, y4));
            desenhador.DrawLine(myPen, new Point(441, y4), new Point(461, y4));
            desenhador.DrawLine(myPen, new Point(524, y4), new Point(544, y4));
            desenhador.DrawLine(myPen, new Point(549, y4), new Point(569, y4));
            desenhador.DrawLine(myPen, new Point(574, y4), new Point(594, y4));
            desenhador.DrawLine(myPen, new Point(599, y4), new Point(619, y4));
            desenhador.DrawLine(myPen, new Point(682, y4), new Point(702, y4));
            desenhador.DrawLine(myPen, new Point(707, y4), new Point(727, y4));
            desenhador.DrawLine(myPen, new Point(732, y4), new Point(752, y4));
            desenhador.DrawLine(myPen, new Point(757, y4), new Point(777, y4));

            //r5
            desenhador.DrawLine(myPen, new Point(50, y5), new Point(70, y5));
            desenhador.DrawLine(myPen, new Point(75, y5), new Point(95, y5));
            desenhador.DrawLine(myPen, new Point(100, y5), new Point(120, y5));
            desenhador.DrawLine(myPen, new Point(125, y5), new Point(145, y5));
            desenhador.DrawLine(myPen, new Point(208, y5), new Point(228, y5));
            desenhador.DrawLine(myPen, new Point(233, y5), new Point(253, y5));
            desenhador.DrawLine(myPen, new Point(258, y5), new Point(278, y5));
            desenhador.DrawLine(myPen, new Point(283, y5), new Point(303, y5));
            desenhador.DrawLine(myPen, new Point(366, y5), new Point(386, y5));
            desenhador.DrawLine(myPen, new Point(391, y5), new Point(411, y5));
            desenhador.DrawLine(myPen, new Point(416, y5), new Point(436, y5));
            desenhador.DrawLine(myPen, new Point(441, y5), new Point(461, y5));
            desenhador.DrawLine(myPen, new Point(524, y5), new Point(544, y5));
            desenhador.DrawLine(myPen, new Point(549, y5), new Point(569, y5));
            desenhador.DrawLine(myPen, new Point(574, y5), new Point(594, y5));
            desenhador.DrawLine(myPen, new Point(599, y5), new Point(619, y5));
            desenhador.DrawLine(myPen, new Point(682, y5), new Point(702, y5));
            desenhador.DrawLine(myPen, new Point(707, y5), new Point(727, y5));
            desenhador.DrawLine(myPen, new Point(732, y5), new Point(752, y5));
            desenhador.DrawLine(myPen, new Point(757, y5), new Point(777, y5));

            //x1
            desenhador.DrawLine(myPen, new Point(y1, 50), new Point(y1, 70));
            desenhador.DrawLine(myPen, new Point(y1, 75), new Point(y1, 95));
            desenhador.DrawLine(myPen, new Point(y1, 100), new Point(y1, 120));
            desenhador.DrawLine(myPen, new Point(y1, 125), new Point(y1, 145));
            desenhador.DrawLine(myPen, new Point(y1, 208), new Point(y1, 228));
            desenhador.DrawLine(myPen, new Point(y1, 233), new Point(y1, 253));
            desenhador.DrawLine(myPen, new Point(y1, 258), new Point(y1, 278));
            desenhador.DrawLine(myPen, new Point(y1, 283), new Point(y1, 303));
            desenhador.DrawLine(myPen, new Point(y1, 366), new Point(y1, 386));
            desenhador.DrawLine(myPen, new Point(y1, 391), new Point(y1, 411));
            desenhador.DrawLine(myPen, new Point(y1, 416), new Point(y1, 436));
            desenhador.DrawLine(myPen, new Point(y1, 441), new Point(y1, 461));
            desenhador.DrawLine(myPen, new Point(y1, 524), new Point(y1, 544));
            desenhador.DrawLine(myPen, new Point(y1, 549), new Point(y1, 569));
            desenhador.DrawLine(myPen, new Point(y1, 574), new Point(y1, 594));
            desenhador.DrawLine(myPen, new Point(y1, 599), new Point(y1, 619));
            desenhador.DrawLine(myPen, new Point(y1, 682), new Point(y1, 702));
            desenhador.DrawLine(myPen, new Point(y1, 707), new Point(y1, 727));
            desenhador.DrawLine(myPen, new Point(y1, 732), new Point(y1, 752));
            desenhador.DrawLine(myPen, new Point(y1, 757), new Point(y1, 777));

            //x2
            desenhador.DrawLine(myPen, new Point(y2, 50), new Point(y2, 70));
            desenhador.DrawLine(myPen, new Point(y2, 75), new Point(y2, 95));
            desenhador.DrawLine(myPen, new Point(y2, 100), new Point(y2, 120));
            desenhador.DrawLine(myPen, new Point(y2, 125), new Point(y2, 145));
            desenhador.DrawLine(myPen, new Point(y2, 208), new Point(y2, 228));
            desenhador.DrawLine(myPen, new Point(y2, 233), new Point(y2, 253));
            desenhador.DrawLine(myPen, new Point(y2, 258), new Point(y2, 278));
            desenhador.DrawLine(myPen, new Point(y2, 283), new Point(y2, 303));
            desenhador.DrawLine(myPen, new Point(y2, 366), new Point(y2, 386));
            desenhador.DrawLine(myPen, new Point(y2, 391), new Point(y2, 411));
            desenhador.DrawLine(myPen, new Point(y2, 416), new Point(y2, 436));
            desenhador.DrawLine(myPen, new Point(y2, 441), new Point(y2, 461));
            desenhador.DrawLine(myPen, new Point(y2, 524), new Point(y2, 544));
            desenhador.DrawLine(myPen, new Point(y2, 549), new Point(y2, 569));
            desenhador.DrawLine(myPen, new Point(y2, 574), new Point(y2, 594));
            desenhador.DrawLine(myPen, new Point(y2, 599), new Point(y2, 619));
            desenhador.DrawLine(myPen, new Point(y2, 682), new Point(y2, 702));
            desenhador.DrawLine(myPen, new Point(y2, 707), new Point(y2, 727));
            desenhador.DrawLine(myPen, new Point(y2, 732), new Point(y2, 752));
            desenhador.DrawLine(myPen, new Point(y2, 757), new Point(y2, 777));

            //x3
            desenhador.DrawLine(myPen, new Point(y3, 50), new Point(y3, 70));
            desenhador.DrawLine(myPen, new Point(y3, 75), new Point(y3, 95));
            desenhador.DrawLine(myPen, new Point(y3, 100), new Point(y3, 120));
            desenhador.DrawLine(myPen, new Point(y3, 125), new Point(y3, 145));
            desenhador.DrawLine(myPen, new Point(y3, 208), new Point(y3, 228));
            desenhador.DrawLine(myPen, new Point(y3, 233), new Point(y3, 253));
            desenhador.DrawLine(myPen, new Point(y3, 258), new Point(y3, 278));
            desenhador.DrawLine(myPen, new Point(y3, 283), new Point(y3, 303));
            desenhador.DrawLine(myPen, new Point(y3, 366), new Point(y3, 386));
            desenhador.DrawLine(myPen, new Point(y3, 391), new Point(y3, 411));
            desenhador.DrawLine(myPen, new Point(y3, 416), new Point(y3, 436));
            desenhador.DrawLine(myPen, new Point(y3, 441), new Point(y3, 461));
            desenhador.DrawLine(myPen, new Point(y3, 524), new Point(y3, 544));
            desenhador.DrawLine(myPen, new Point(y3, 549), new Point(y3, 569));
            desenhador.DrawLine(myPen, new Point(y3, 574), new Point(y3, 594));
            desenhador.DrawLine(myPen, new Point(y3, 599), new Point(y3, 619));
            desenhador.DrawLine(myPen, new Point(y3, 682), new Point(y3, 702));
            desenhador.DrawLine(myPen, new Point(y3, 707), new Point(y3, 727));
            desenhador.DrawLine(myPen, new Point(y3, 732), new Point(y3, 752));
            desenhador.DrawLine(myPen, new Point(y3, 757), new Point(y3, 777));

            //x4
            desenhador.DrawLine(myPen, new Point(y4, 50), new Point(y4, 70));
            desenhador.DrawLine(myPen, new Point(y4, 75), new Point(y4, 95));
            desenhador.DrawLine(myPen, new Point(y4, 100), new Point(y4, 120));
            desenhador.DrawLine(myPen, new Point(y4, 125), new Point(y4, 145));
            desenhador.DrawLine(myPen, new Point(y4, 208), new Point(y4, 228));
            desenhador.DrawLine(myPen, new Point(y4, 233), new Point(y4, 253));
            desenhador.DrawLine(myPen, new Point(y4, 258), new Point(y4, 278));
            desenhador.DrawLine(myPen, new Point(y4, 283), new Point(y4, 303));
            desenhador.DrawLine(myPen, new Point(y4, 366), new Point(y4, 386));
            desenhador.DrawLine(myPen, new Point(y4, 391), new Point(y4, 411));
            desenhador.DrawLine(myPen, new Point(y4, 416), new Point(y4, 436));
            desenhador.DrawLine(myPen, new Point(y4, 441), new Point(y4, 461));
            desenhador.DrawLine(myPen, new Point(y4, 524), new Point(y4, 544));
            desenhador.DrawLine(myPen, new Point(y4, 549), new Point(y4, 569));
            desenhador.DrawLine(myPen, new Point(y4, 574), new Point(y4, 594));
            desenhador.DrawLine(myPen, new Point(y4, 599), new Point(y4, 619));
            desenhador.DrawLine(myPen, new Point(y4, 682), new Point(y4, 702));
            desenhador.DrawLine(myPen, new Point(y4, 707), new Point(y4, 727));
            desenhador.DrawLine(myPen, new Point(y4, 732), new Point(y4, 752));
            desenhador.DrawLine(myPen, new Point(y4, 757), new Point(y4, 777));

            //x5
            desenhador.DrawLine(myPen, new Point(y5, 50), new Point(y5, 70));
            desenhador.DrawLine(myPen, new Point(y5, 75), new Point(y5, 95));
            desenhador.DrawLine(myPen, new Point(y5, 100), new Point(y5, 120));
            desenhador.DrawLine(myPen, new Point(y5, 125), new Point(y5, 145));
            desenhador.DrawLine(myPen, new Point(y5, 208), new Point(y5, 228));
            desenhador.DrawLine(myPen, new Point(y5, 233), new Point(y5, 253));
            desenhador.DrawLine(myPen, new Point(y5, 258), new Point(y5, 278));
            desenhador.DrawLine(myPen, new Point(y5, 283), new Point(y5, 303));
            desenhador.DrawLine(myPen, new Point(y5, 366), new Point(y5, 386));
            desenhador.DrawLine(myPen, new Point(y5, 391), new Point(y5, 411));
            desenhador.DrawLine(myPen, new Point(y5, 416), new Point(y5, 436));
            desenhador.DrawLine(myPen, new Point(y5, 441), new Point(y5, 461));
            desenhador.DrawLine(myPen, new Point(y5, 524), new Point(y5, 544));
            desenhador.DrawLine(myPen, new Point(y5, 549), new Point(y5, 569));
            desenhador.DrawLine(myPen, new Point(y5, 574), new Point(y5, 594));
            desenhador.DrawLine(myPen, new Point(y5, 599), new Point(y5, 619));
            desenhador.DrawLine(myPen, new Point(y5, 682), new Point(y5, 702));
            desenhador.DrawLine(myPen, new Point(y5, 707), new Point(y5, 727));
            desenhador.DrawLine(myPen, new Point(y5, 732), new Point(y5, 752));
            desenhador.DrawLine(myPen, new Point(y5, 757), new Point(y5, 777));

            //x6
            desenhador.DrawLine(myPen, new Point(y6, 50), new Point(y6, 70));
            desenhador.DrawLine(myPen, new Point(y6, 75), new Point(y6, 95));
            desenhador.DrawLine(myPen, new Point(y6, 100), new Point(y6, 120));
            desenhador.DrawLine(myPen, new Point(y6, 125), new Point(y6, 145));
            desenhador.DrawLine(myPen, new Point(y6, 208), new Point(y6, 228));
            desenhador.DrawLine(myPen, new Point(y6, 233), new Point(y6, 253));
            desenhador.DrawLine(myPen, new Point(y6, 258), new Point(y6, 278));
            desenhador.DrawLine(myPen, new Point(y6, 283), new Point(y6, 303));
            desenhador.DrawLine(myPen, new Point(y6, 366), new Point(y6, 386));
            desenhador.DrawLine(myPen, new Point(y6, 391), new Point(y6, 411));
            desenhador.DrawLine(myPen, new Point(y6, 416), new Point(y6, 436));
            desenhador.DrawLine(myPen, new Point(y6, 441), new Point(y6, 461));
            desenhador.DrawLine(myPen, new Point(y6, 524), new Point(y6, 544));
            desenhador.DrawLine(myPen, new Point(y6, 549), new Point(y6, 569));
            desenhador.DrawLine(myPen, new Point(y6, 574), new Point(y6, 594));
            desenhador.DrawLine(myPen, new Point(y6, 599), new Point(y6, 619));
            desenhador.DrawLine(myPen, new Point(y6, 682), new Point(y6, 702));
            desenhador.DrawLine(myPen, new Point(y6, 707), new Point(y6, 727));
            desenhador.DrawLine(myPen, new Point(y6, 732), new Point(y6, 752));
            desenhador.DrawLine(myPen, new Point(y6, 757), new Point(y6, 777));
            


        }

        private void DesenhaNumeroCruzamentos()
        {
            //for (int i = 0; i < Cruzamentos.Length; i++)
                //desenhador.DrawString((i + 1).ToString(), new Font("Arial", 16), new SolidBrush(Color.Blue),  Cruzamentos[i].X, Cruzamentos[i].Y);
        }

        private void AtualizaMapa()
        {
            pictureBox2.Invalidate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            img = new Bitmap(pictureBox2.Width, pictureBox2.Height); //criar a folha em branco  
            pictureBox2.BackgroundImage = img;
            desenhador = Graphics.FromImage(img);
            desenhador.Clear(Color.Black); //limpa e atribuir a cor cinza do mapa

            /*Desenha Mapa incial*/
            DesenhaQuarteroes();
            DesenhaAvenidas();
            DesenhaFaixas();
            DesenhaNumeroCruzamentos();
            
            AtualizaMapa();

            AtribuiCruzamentos();
             
            /*Para Auto Teste*/
            //AutoTesteMapa();

            /*Chamar exe*/
           Process.Start(@"C:\GitHub\TRB2-IA\TRB2-IA-AG-ROTAS\AG_ROTAS\bin\Debug\AG_ROTAS.exe");
            /*Para Leitura No arquivo*/
            Thread.Sleep(8000);
            if (LeituraRotas.RealizarLeituraRota()) DesenhaMelhorRota();

            AtualizaMapa();

        }
        private void AutoTesteMapa()
        {
            timer1.Enabled = true;

        }

        private void AtribuiCruzamentos()
        {
            Cruzamentos[0] = cruzamento_1;
            Cruzamentos[1] = cruzamento_2;
            Cruzamentos[2] = cruzamento_3;
            Cruzamentos[3] = cruzamento_4;
            Cruzamentos[4] = cruzamento_5;
            Cruzamentos[5] = cruzamento_6;
            Cruzamentos[6] = cruzamento_7;
            Cruzamentos[7] = cruzamento_8;
            Cruzamentos[8] = cruzamento_9;
            Cruzamentos[9] = cruzamento_10;
            Cruzamentos[10] = cruzamento_11;
            Cruzamentos[11] = cruzamento_12;
            Cruzamentos[12] = cruzamento_13;
            Cruzamentos[13] = cruzamento_14;
            Cruzamentos[14] = cruzamento_15;
            Cruzamentos[15] = cruzamento_16;
            Cruzamentos[16] = cruzamento_17;
            Cruzamentos[17] = cruzamento_18;
            Cruzamentos[18] = cruzamento_19;
            Cruzamentos[19] = cruzamento_20;
            Cruzamentos[20] = cruzamento_21;
            Cruzamentos[21] = cruzamento_22;
            Cruzamentos[22] = cruzamento_23;
            Cruzamentos[23] = cruzamento_24;
            Cruzamentos[24] = cruzamento_25;
            Cruzamentos[25] = cruzamento_26;
            Cruzamentos[26] = cruzamento_27;
            Cruzamentos[27] = cruzamento_28;
            Cruzamentos[28] = cruzamento_29;
            Cruzamentos[29] = cruzamento_30;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void DesenhaMelhorRota()
        {
            AutoTesteMapa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (i < LeituraRotas.Rota.Count)
            {
                desenhador.FillRectangle(Brushes.Red, Cruzamentos[LeituraRotas.Rota[i] - 1]);
                desenhador.DrawString(LeituraRotas.Rota[i].ToString(), new Font("Arial", 16), new SolidBrush(Color.Blue), Cruzamentos[LeituraRotas.Rota[i] - 1].X, Cruzamentos[LeituraRotas.Rota[i] - 1].Y);
                i++;
               
            }

            else
            {
                DesenhaAvenidas();
                DesenhaFaixas();
                i = 0;
            }
            //DesenhaNumeroCruzamentos();
            this.ResumeLayout();
            AtualizaMapa();
        }
    }
}

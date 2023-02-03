using System;
using System.Windows;

namespace Крестики_нолики
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        int save_simvol = 0;
        int save_button = 0;
        int game_two=0;

        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Start_game_Click(object sender, RoutedEventArgs e)
        {
            save_button = 0;
            Button_1.Content = "";
            Button_2.Content = "";
            Button_3.Content = "";
            Button_4.Content = "";
            Button_5.Content = "";
            Button_6.Content = "";
            Button_7.Content = "";
            Button_8.Content = "";
            Button_9.Content = "";
            prochess_play.Text = "Игра началась";
            Button_1.IsEnabled = true;
            Button_2.IsEnabled = true;
            Button_3.IsEnabled = true;
            Button_4.IsEnabled = true;
            Button_5.IsEnabled = true;
            Button_6.IsEnabled = true;
            Button_7.IsEnabled = true;
            Button_8.IsEnabled = true;
            Button_9.IsEnabled = true;
            if(game_two==1)
            {
                save_simvol = 0;
                Name();
            }
            if(game_two==0)
            {
                save_simvol = 0;
            }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_1.Content = "O";
                Button_1.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_1.Content = "X";
                Button_1.IsEnabled = false;
                save_simvol = 1;
            }
            
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_2_Click_1(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_2.Content = "O";
                Button_2.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_2.Content = "X";
                Button_2.IsEnabled = false;
                save_simvol = 1;
            }
            
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_3_Click_1(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_3.Content = "O";
                Button_3.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_3.Content = "X";
                Button_3.IsEnabled = false;
                save_simvol = 1;
            }
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_4.Content = "O";
                Button_4.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_4.Content = "X";
                Button_4.IsEnabled = false;
                save_simvol = 1;
            }
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }
        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_5.Content = "O";
                Button_5.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_5.Content = "X";
                Button_5.IsEnabled = false;
                save_simvol = 1;
            }
            
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {   
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_6.Content = "O";
                Button_6.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_6.Content = "X";
                Button_6.IsEnabled = false;
                save_simvol = 1;
            }
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_7.Content = "O";
                Button_7.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_7.Content = "X";
                Button_7.IsEnabled = false;
                save_simvol = 1;
            }
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_8.Content = "O";
                Button_8.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_8.Content = "X";
                Button_8.IsEnabled = false;
                save_simvol = 1;
            }
            
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (save_simvol == 1)
            {
                Button_9.Content = "O";
                Button_9.IsEnabled = false;
                save_simvol = 0;
            }
            else
            {
                Button_9.Content = "X";
                Button_9.IsEnabled = false;
                save_simvol = 1;
            }
            if (save_button == 8)
            {
                Button_prros();
            }
            else
            {
                save_button = save_button + 1;
                Name();
            }
            win();
        }
        private void Name()
        {
        united:
            Random r = new Random();
            int knopka = r.Next(1, 9);
            if (knopka == 1)
            {
                if (Button_1.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_1.Content = "O";
                        Button_1.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_1.Content = "X";
                        Button_1.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 2)
            {
                if (Button_2.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_2.Content = "O";
                        Button_2.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_2.Content = "X";
                        Button_2.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 3)
            {
                if (Button_3.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_3.Content = "O";
                        Button_3.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_3.Content = "X";
                        Button_3.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 4)
            {
                if (Button_4.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_4.Content = "O";
                        Button_4.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_4.Content = "X";
                        Button_4.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 5)
            {
                if (Button_5.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_5.Content = "O";
                        Button_5.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_5.Content = "X";
                        Button_5.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 6)
            {
                if (Button_6.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_6.Content = "O";
                        Button_6.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_6.Content = "X";
                        Button_6.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 7)
            {
                if (Button_7.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_7.Content = "O";
                        Button_7.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_7.Content = "X";
                        Button_7.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 8)
            {
                if (Button_8.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_8.Content = "O";
                        Button_8.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_8.Content = "X";
                        Button_8.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            if (knopka == 9)
            {
                if (Button_9.IsEnabled == true)
                {
                    if (save_simvol == 1)
                    {
                        Button_9.Content = "O";
                        Button_9.IsEnabled = false;
                        save_simvol = 0;
                    }
                    else
                    {
                        Button_9.Content = "X";
                        Button_9.IsEnabled = false;
                        save_simvol = 1;
                    }
                    if (save_button == 8)
                    {
                        Button_prros();
                    }
                    win();
                }
                else
                {
                    goto united;
                }
            }
            save_button = save_button + 1;
        }
        private void win()
        {
            if (Button_1.Content=="X" && Button_4.Content=="X" && Button_7.Content=="X" || Button_2.Content == "X" && Button_5.Content == "X" && Button_8.Content == "X" || Button_3.Content == "X" && Button_6.Content == "X" && Button_9.Content == "X")
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                prochess_play.Text = "Победили крестики";
                if (game_two == 1)
                {
                    game_two = 0;
                }
                if (game_two == 0)
                {
                    game_two = 1;
                }
            }
            if(Button_1.Content == "X" && Button_2.Content == "X" && Button_3.Content == "X" || Button_4.Content == "X" && Button_5.Content == "X" && Button_6.Content == "X" || Button_7.Content == "X" && Button_8.Content == "X" && Button_9.Content == "X")
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                prochess_play.Text = "Победили крестики";
                if (game_two == 1)
                {
                    game_two = 0;
                }
                if (game_two == 0)
                {
                    game_two = 1;
                }
            }
            if (Button_1.Content == "X" && Button_5.Content == "X" && Button_9.Content == "X" || Button_3.Content == "X" && Button_5.Content == "X" && Button_7.Content == "X")
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                prochess_play.Text = "Победили крестики";
                if (game_two == 1)
                {
                    game_two = 0;
                }
                if (game_two == 0)
                {
                    game_two = 1;
                }
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            if (Button_1.Content == "O" && Button_4.Content == "O" && Button_7.Content == "O" || Button_2.Content == "O" && Button_5.Content == "O" && Button_8.Content == "O" || Button_3.Content == "O" && Button_6.Content == "O" && Button_9.Content == "O")
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                prochess_play.Text = "Победили нолики";
                if (game_two == 1)
                {
                    game_two = 0;
                }
                if (game_two == 0)
                {
                    game_two = 1;
                }
            }
            if(Button_1.Content == "O" && Button_2.Content == "O" && Button_3.Content == "O" || Button_4.Content == "O" && Button_5.Content == "O" && Button_6.Content == "O" || Button_7.Content == "O" && Button_8.Content == "O" && Button_9.Content == "O")
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                prochess_play.Text = "Победили нолики";
                if (game_two == 1)
                {
                    game_two = 0;
                }
                if (game_two == 0)
                {
                    game_two = 1;
                }
            }
            if (Button_1.Content == "O" && Button_5.Content == "O" && Button_9.Content == "O" || Button_3.Content == "O" && Button_5.Content == "O" && Button_7.Content == "O")
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                prochess_play.Text = "Победили нолики";
                
            }
        }

        private void Button_prros()
        {
            if (Button_1.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_1.Content = "O";
                    Button_1.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_1.Content = "X";
                    Button_1.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_2.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_2.Content = "O";
                    Button_2.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_2.Content = "X";
                    Button_2.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_3.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_3.Content = "O";
                    Button_3.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_3.Content = "X";
                    Button_3.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_4.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_4.Content = "O";
                    Button_4.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_4.Content = "X";
                    Button_4.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_5.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_5.Content = "O";
                    Button_5.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_5.Content = "X";
                    Button_5.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_6.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_6.Content = "O";
                    Button_6.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_6.Content = "X";
                    Button_6.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_7.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_7.Content = "O";
                    Button_7.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_7.Content = "X";
                    Button_7.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_8.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_8.Content = "O";
                    Button_8.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_8.Content = "X";
                    Button_8.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            if (Button_9.IsEnabled == true)
            {
                if (save_simvol == 1)
                {
                    Button_9.Content = "O";
                    Button_9.IsEnabled = false;
                    save_simvol = 0;
                }
                else
                {
                    Button_9.Content = "X";
                    Button_9.IsEnabled = false;
                    save_simvol = 1;
                }
            }
            prochess_play.Text = "Ничья";
            if (game_two == 1)
            {
                game_two = 0;
            }
            if (game_two == 0)
            {
                game_two = 1;
            }
        }
    }
}

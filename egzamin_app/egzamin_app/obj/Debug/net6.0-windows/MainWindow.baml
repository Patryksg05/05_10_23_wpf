   M S B A M L   `   `   `  ����F  Begzamin_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:egzamin_appegzamin_app  5   	       egzamin_app.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:egzamin_app     5   	     � Title$+  %Nadaj Przesyłkę, PESEL: 00000000000��5   	   $	��350��5	   	   $	��600��6   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��6* �6   �� 5      .+�5   
   �  5      �� 5      $��2* �6    �� 5      �� 5      .+�5      �� $��Rodzaj przesyłki��5      $��
30 20 20 5q�5      .��5      �� .+�5       	� -   5         	�Name$ postcard��5$      $��
Pocztówka��5!       d� 	IsChecked$ FalseY�5"       	� 	GroupName$
 type��5#      $��	10 10 0 5q�5%      	� 5'      -   5        $
 list��5+      $
��List��5(      $
 TrueY�5)      $
 type��5*      $��10 0 0 5q�5,      	� 5.      -   5        $
 pack��52      $��Paczka��5/      $ FalseY�50      $
 type��51      $��10 0 0 5q�53      55      56      �� 58      -   5        $��Sprawdz cene��59      $��1��5;      $��20��5<      $��30 -50 20 0q�5=      � 5?      $��2��6   $��30 -30 30 0q�6     5@      �� 5A      �� 5B      .+�5E      �� -   5         ��Name$ image��5F      $��../../../images/list.png��5G      �� 5I      -   5         ��Name$ price��5J      $��1��5K      $��Cena: 1,5 zl��5L      $
��Bold"�5M      $��13(�5N      $��	20 15 0 0q�5O      5R      5T      �� 5V   
   $��Dane adresowe��5W      $��1��5X      $��
0 20 30 20q�5Y      .��5[      �� .+�5]      �� $��Ulica z numerem��6   $��8 10 0 0q�62   �� 5^      -   5         ��Name$ street_text_box��5_      $��Konopnickiej 89��5`      $��	10 0 10 0q�5a      �� 5c      $��Kod pocztowy��6   $��8 10 0 0q�6/   �� 5d      -   5        $ post_code_text_box��5e      $��65124��5f      $��	10 0 10 0q�5g      �� 5i      $��Miasto��6   $��8 10 0 0q�6)   �� 5j      -	   5        $ city_text_box��5k      $��	10 0 10 0q�5l      5n      5p      �� 5r   
   $��1��5s      $��2��5t      $��Bottom=�5u      .+�5w      �� -
   5        $��	Zatwierdz��5x      $��	30 0 30 0q�5y      5z      5|      5}      5~      
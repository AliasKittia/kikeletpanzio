   M S B A M L   `   `   `  ����K  Gkikeletpanzio2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:kikeletpanzio2._0kikeletpanzio2._0  5   	       kikeletpanzio2._0.Sign_in   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:kikeletpanzio2._0     5   	     � Title$  Sign_in��5   	   $	��680��6   $	��800��6&    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ 15(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� .+�5      �� $��Vezetéknév:��6   �� 5      -   5         ��Name$ 	FirstName��5       �� TextWrapping$
 Wrap=�6)   $	��380��6=   �� 5      $��Keresztnév:��6   �� 5      -   5        $ LastName��5      $
 Wrap=�6(   $	��380��6<   5      �� 5   
   $��1��6   .+�5       �� $��Születési hely:��6   �� 5!      -   5        $ 
BirthPlace��5!      $
 Wrap=�6*   $	��380��6>   �� 5#      $��Születési idő:��6   (  "System.Windows.Controls.DatePicker  5$      -   5          Name$ 	Birthdate��5$      $	��380��6,   5%      �� 5'   
   $��2��6   $��0,0,0,86q�6"   $��2��64   .+�5(      �� $��Telefonszám:��6   �� 5)      -   5        $ Phonenumber��5)      $
 Wrap=�6+   $	��380��6?   �� 5+      $��Email cím:��6   �� 5,      -   5        $ Email��5,      $
 Wrap=�6%   $	��380��69   �� 5.      $��Jelszó:��6   G� 5/      -   5        	 G�Name$	 	Password1��5/      $	��380��6-   �� 50      $��Jelszó ismét:��6   G� 51      -   5        $	 	Password2��51      $	��380��6-   �� 53      $��Szeretne VIP tag lenni?��6   	� 54      -	   5        
 	�Name$
 RB_Yes��54      $
��Igen��6*   	� 55      -
   5        $
 RB_No��55      $	��Nem��6)   56      ]� 58   
   $��3��6   .+�59      �� -   5         ��Name$
 Save��59      $ ��Regisztráció befejezése��6#   $	��377��6E   $��45��6Q   6]   5:      5;      5<      
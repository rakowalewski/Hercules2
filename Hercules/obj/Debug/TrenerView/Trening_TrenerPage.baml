   M S B A M L   `   `   `  ����C  ?Hercules, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Hercules.TrenerViewHercules.TrenerView  5      ,    &Hercules.TrenerView.Trening_TrenerPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Hercules.TrenerView     5        N� Title$  Trening_TrenerPage��5	      .��5      � $��0,0,-337,-176q�6   .+�5   
   �� -   5        .@�5      �� $��Dodaj trening��6   .��5      � .+�5      �� $��Trener:��6   $
��Left=�6.   $��7,10,0,0q�6I   $	��Top=�6[   �� 5      -   5         ��Name$ trenerTreningCB��5      $
��Left=�68   $��
141,14,0,0q�6S   $	��Top=�6g   $	��120��6   6�   �� 5      $��Pesel klienta:��6   $
��Left=�65   $��7,50,0,0q�6P   $	��Top=�6b   �� 5      -   5         ��Name$ peselKlientaTB��5      $
��Left=�66   $��23��6Q   $��
141,53,0,0q�6]    �� TextWrapping$
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5      $��Rozpoczęcie treningu:��6   $
��Left=�6<   $��	10,85,0,0q�6W   $	��Top=�6j   �� 5      $��Zakończenie treningu:��6   $
��Left=�6<   $��
10,116,0,0q�6W   $	��Top=�6k   �� 5      $��Należność: ��6   $
��Left=�62   $��
15,180,0,0q�6M   $	��Top=�6a   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ rozpoczecieDP��5   !   $
��Left=�68   $��
141,87,0,0q�6S   $	��Top=�6g     5      -   5        $ zakonczenieDP��5   !   $
��Left=�68   $��141,118,0,0q�6S   $	��Top=�6h   �� 5      -   5        $ naleznoscTB��5      $
��Left=�63   $��23��6N   $��141,180,0,0q�6Z   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��Dodaj��5      $
��Left=�6-   $��141,235,0,0q�6H   $	��Top=�6]   $	��120��6u   $��40��6�   6�   �� 5      -   5         ��Name$ czyZakonczonyCHB��5      $��Czy zakończony?��69   $
��Left=�6S   $��141,153,0,0q�6n   $	��Top=�6�   5      5      �� 5       $��Wyszukaj trening��6   .��5!      � .+�5"      �� $��Trener��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   �� 5#      -	   5        $ trenerTreningSzukajCB��5#      $
��Left=�6>   $��	58,14,0,0q�6Y   $	��Top=�6l   $	��120��6�   6�   �� 5$      $��Data: ��6   $
��Left=�6-   $��
266,14,0,0q�6H   $	��Top=�6\     5%      -
   5        $ dataTreningDP��5%   !   $
��Left=�68   $��
317,16,0,0q�6S   $	��Top=�6g   {�.  6   �� 5&      -   5         ��Name$ 	szukajBTN��5&      $��Szukaj��60   $
��Left=�6A   $��
457,17,0,0q�6\   $	��Top=�6p   $��90��6�   $��23��6�   6�   &   System.Windows.Controls.DataGrid  5'      -   5          Name$ 	TreningDG��5'      $
��Left=�62   $	��373��6M   $��	10,65,0,0q�6Z   $	��Top=�6m   $	��611��6�   �� 5(      -   5        $ dniaCHB��5(      $��Trening Dnia��60   $
��Left=�6G   $��
272,45,0,0q�6b   $	��Top=�6v   6�   5*      5,      51      53      54      
   M S B A M L   `   `   `  ����C  ?Hercules, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Hercules.TrenerViewHercules.TrenerView  5      /    )Hercules.TrenerView.Statystyki_TrenerPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Hercules.TrenerView     5        N� Title$  Statystyki_TrenerPage��5      $	��955��6%   $
��1195��62   $
��Left=�6?   $	��Top=�6Z   .��5
      � $��0,0,-610,-500q�6   .+�5   
   �� $
��Left=�6   $	��948��60   $��	10,10,0,0q�6=   $	��Top=�6P   $
��1186��6h   .@�5      �� $��Raporty��6   .��5      � ���	#FFE5E5E5.+�5      �� $��Wybierz Trenera:��6   $
��Left=�67   $��	10,10,0,0q�6R   $	��Top=�6e   $��3��6}   �� 5      -   5         ��Name$ TrenerCB��5      $
��Left=�61   $��
113,14,0,0q�6L   $	��Top=�6`   $	��141��6x   6�   �� 5      $��Rok: ��6   $
��Left=�6,   $��173,176,0,0q�6G   $	��Top=�6\   $��2��6t   �� 5      -   5         ��Name$ RokRokTB��5      $
��Left=�60   $��23��6K   $��214,176,0,0q�6W    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��120��6�   $��2��6�   �� 5      -   5         ��Name$ PobierzMiesiacBTN��5      $��Pobierz��68   $
��Left=�6J   $��
385,90,0,0q�6e   $	��Top=�6y   $��87��6�   $��23��6�   $��2��6�   6�   �� 5      -   5        $ PobierzRokBTN��5      $��Pobierz��64   $
��Left=�6F   $��385,176,0,0q�6a   $	��Top=�6v   $��87��6�   $��23��6�   $��2��6�   6�   �� 5      $��	Zarobki: ��6   $
��Left=�60   $��
543,90,0,0q�6K   $	��Top=�6_   $��2��6w   �� 5      $��	Zarobki: ��6   $
��Left=�60   $��543,173,0,0q�6K   $	��Top=�6`   $��2��6x   �� 5      -   5        $ ZarobkiMiesiacTB��5      $
��Left=�68   $��23��6S   $��
604,90,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   $��2��6�   �� 5      -   5        $ ZarobkiRokTB��5      $
��Left=�64   $��23��6O   $��604,173,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��120��6�   $��2��6�   �� 5      $	��zł��6   $
��Left=�6)   $��
729,90,0,0q�6D   $	��Top=�6X   $��2��6p   �� 5      $	��zł��6   $
��Left=�6)   $��729,169,0,0q�6D   $	��Top=�6Y   $��2��6q   �� 5      $��Raport miesięczny��6   $
��Left=�68   $��
385,53,0,0q�6S   $	��Top=�6g   $��14(�6   $
��Bold"�6�   $��2��6�   �� 5      $��Raport roczny: ��6   $
��Left=�66   $��371,134,0,0q�6Q   $	��Top=�6f   $��14(�6~   $
��Bold"�6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ poczatkowaDP��5   !   $
��Left=�67   $��	37,90,0,0q�6R   $	��Top=�6e     5      -   5        $ 	koncowaDP��5   !   $
��Left=�64   $��
200,92,0,0q�6O   $	��Top=�6c   �� 5      $��Data początkowa��6   $
��Left=�66   $��	37,55,0,0q�6Q   $	��Top=�6d   �� 5       $��Data końcowa��6   $
��Left=�63   $��
200,64,0,0q�6N   $	��Top=�6b   5!      5"      �� 5#      $��Historia Treningów��6   .��5$      � ���	#FFE5E5E5.+�5%      �� -	   5        $��trenerHistoriaCB��5%      $
��Left=�67   $��
140,56,0,0q�6R   $	��Top=�6f   $	��120��6~   6�   �� 5&      -
   5        $��peselHistoriaTreningowTB��5&      $
��Left=�6>   $��23��6Y   $��
125,21,0,0q�6e   $
 Wrap=�6y   $	��Top=�6�   $	��120��6�   �� 5'      $��Podaj Pesel Klienta: ��6   $
��Left=�6<   $��	10,21,0,0q�6W   $	��Top=�6j    J� RenderTransformOrigin$ 0.359,-0.333&�6�   �� 5(      $��Wybierz login trenera: ��6   $
��Left=�6>   $��	10,56,0,0q�6Y   $	��Top=�6l   �� 5)      -   5        $��historiaTreningowBTN��5)      $��Historia Treningów��69   $
��Left=�6V   $��	71,95,0,0q�6q   $	��Top=�6�   $	��121��6�   $��31��6�   6�   &   System.Windows.Controls.DataGrid  5*      -   5        $��historiaTreningowDG��5*      $
��Left=�6:   $	��706��6U   $��	0,144,0,0q�6b   $	��Top=�6u   $
��1160��6�   5,      5-      5.      50      51      
   M S B A M L   `   `   `  ����h  dGeneratorFałszywejTożsamości_Warczak_Kamil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:GeneratorFałszywejTożsamości_Warczak_Kamil-GeneratorFałszywejTożsamości_Warczak_Kamil  5   	   >    8GeneratorFałszywejTożsamości_Warczak_Kamil.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:GeneratorFałszywejTożsamości_Warczak_Kamil     5   	     � Title$'  !Generator fałszywej tożsamości��5   	   $��475.013��60   $��918.689��6A   
�������.��5	      � .+�5
   
   �� $'��!Wprowadź Swoją datę urodzin : ��6   $
��Left=�69   $��	80,60,0,0q�6T   $	��Top=�6g   $	��177��6   $��24��6�   �� 5   
   $��Wybierz Swoją płeć: ��6   $
��Left=�6/   $��
80,114,0,0q�6J   $	��Top=�6^   $	��177��6v   �� 5   
   -   5         ��Name$ ComboBox_Płci��5      $
��Left=�6*   $��289,118,0,0q�6E   $	��Top=�6Z   $	��169��6r   .@�5      �� .��6   Mężczyzna6&   �� 5      .��6   	Kobieta6$   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateBornPicker��5      $
��Left=�6-   $��
289,61,0,0q�6H   $	��Top=�6\   $	��169��6t      DisplayDateStart$ 
1800-01-01X�6�      DisplayDateEnd$ 
2299-12-31X�6�   ]� 5   
   $
��Left=�6   $��26��6/   ��.  $	��Top=�6Q   $	��901��6i   .+�5      o� $	��Top=�6   $��	0,0,-11,0q�6(   .@�5      m� $��_Program��6   .@�5      m� -   5        $��Creator��5      60   m� 5      -   5        $
��Exit��5      6-   5      5      5      �� 5   
   $��Wygenerowany PESEL:��6   $
��Left=�6.   $��
80,324,0,0q�6I   $	��Top=�6]   $	��248��6u   $��24(�6�   �� 5   
   $��3q�6   
���   �$��344,330,306,78q�69    J� RenderTransformOrigin$ 0.356,-0.045&�6Q   ._�5      �� -   5         ��Name$% TextBlock_Wygenerowanego_PESELU��5      $
��Left=�6A   $��-3q�6\   $
��Wrap=�6h   $	��Top=�6|   $��36��6�   $	��261��6�   $��24(�6�   5      �� 5   
   -   5         ��Name$ Generowanie_PESELU��5      $��Generuj PESEL��6-   $
��Left=�6E   $��344,241,0,0q�6`   $	��Top=�6u   $	��128��6�   $��35��6�   6�   �� 5   
   $5��/Naciśnij przycisk, aby wygenerować PESEL --->��6   $
��Left=�6H   $��
80,246,0,0q�6c   $	��Top=�6w   $	��259��6�   5      5       
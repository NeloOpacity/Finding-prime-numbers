   M S B A M L   `   `   `  ����C  ?SegaMega, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SegaMegaSegaMega  5   	   M ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=SystemSystem.ComponentModel 5   	       SegaMega.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SegaMega     5   	   Bcm3clr-namespace:System.ComponentModel;assembly=System     5   	     � Title$  Тест��5	   	   $	��450��6   $	��800��6#    � 	Resources 5
      ,  &System.ComponentModel.BackgroundWorker   backgroundWorker   WorkerReportsProgress!   WorkerSupportsCancellation��%=   &	          5   
   -   5         .  . 5      5      .��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $
��От��6-   $��Center=�6:   �� 5   
   $��0��6   $��1��6   $
��До��6-   $��Center=�6:   �� 5   
   $��1��6   $��0��6   $��Результат��6-   $��Center=�6A   �� 5   
   -   5        $
��From��5      $��0��6   $��Stretch=�6+   $��Center=�6I   $��40q�6d   $��0��6p   �� 5   
   -   5        $��To��5      $��0��6   $��Stretch=�6)   $��Center=�6G   $��40q�6b   $��1��6n   �� 5   
   -   5        $��Result��5      $��1��6    $��0��6-   $��30q�6=   �� 5   
   $��1��6   $��1��6"   .+�5      �� -   5        $��bSubmit��5      $*��$Найти простые числа��6$   $��10q�6B   $��10q�6O   $��Right=�6\   6x   �� 5       -   5        $��bCancel��5       $��Отменить��6$   {�.  $��10q�6I   $��10q�6V   $��Right=�6c   ��6   ��  �� ElementName$ bSubmit�� �� Path$ Width�6�   5!      � 5"   
   -   5        $��progressBar��5"      $��1��6)   $��2��66   $��Bottom=�6J   $��30��6e   5#      5$      
   M S B A M L   `   `   `  ����D  @kapsParty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kapsParty	kapsParty  5   	       kapsParty.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:kapsParty     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$ 
HolidayApp��5	   	   $	��370��6   $
��1041��6)    � Icon$ 	/icon.png��66    � 
ResizeMode$ NoResize=�6G   ���	#FF5B0B0B$��Stretch=�6t   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6�   .��5
      �  � Cursor$  ��6   $��0,0,0,1q�6   ��5   
   �� 5       �� ImageSource$ /backgrond.jpg��6   .+�5   
   �� -   5        $��Holidays��5      $
��Left=�6#   $��266,170,0,0q�6>   $	��Top=�6S   $	��192��6k   $��26��6w   $��Bahnschrift Light)�6�   $��14(�6�   6�   �� 5   
   -   5        $
��Name��5      $
��Left=�6   $��
266,66,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��192��6y   $��26��6�   $��Bahnschrift Light)�6�   $��18(�6�   $
��True��6�   " �� VerticalScrollBarVisibility$
 Auto=�6  �� 5   
   -   5        $��Output��5      $
��Left=�6    $��
520,66,0,0q�6;   $
 Wrap=�6O   $	��Top=�6c   $	��480��6{   $	��241��6�   $��16(�6�   $ �� HorizontalScrollBarVisibility$ Visible=�6�   $ Visible=�6�   	 �� 
IsReadOnly$
	 True��6�   �� 5   
   $��Получатель:��6   $
��Left=�6&   $��	20,66,0,0q�6A   $	��Top=�6T   $��Arial)�6l   $
��Bold"�6   $��1,1,1,1q�6�   
���   �$��18(�6�   �� 5   
   $��Праздник:��6   $
��Left=�6$   $��
22,166,0,0q�6?   $	��Top=�6S   $��Arial)�6k   $
��Bold"�6~   $��1,1,1,1q�6�   $��18(�6�   �� 5   
   -   5        $��Отправить��5      $
��Left=�6%   $��270,274,0,0q�6@   $	��Top=�6U   $	��121��6m   ���	#FFAC0808
�������$��33��6�   
�������$��14(�6�   �� 5   
   -   5        $��Mailto��5      $
��Left=�6    $��266,222,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $	��192��6|   $��24��6�   $ Hidden=�6�   $
 Auto=�6�   $
��True��6�   $��18(�6  �� 5   
   $ ��Укажите почту:��6   $
��Left=�6)   $��
22,225,0,0q�6D   $	��Top=�6X   $��36��6p   $��Arial)�6|   $
��Bold"�6�   $��1,1,1,1q�6�   $��18(�6�   �� 5   
   $]��WПоздравьте своих родных и близких с праздником!��6   $
��Left=�6J   $��
327,10,0,0q�6e   $	��Top=�6y   $
��Bold"�6�   $��22(�6�   $��1,1,1,1q�6�   
����������	#FFAC08086�   �� 5   
   -   5        
 ��Name$
 Count��5      $
��Left=�6!   $��266,114,0,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $	��192��6}   $��26��6�   $��18(�6�   �� 5   
   $.��(Количество пожеланий:��6   $
��Left=�60   $��
20,106,0,0q�6K   $	��Top=�6_   $
��Bold"�6w   $��1,1,1,1q�6�   $��18(�6�   $��42��6�   5      5      
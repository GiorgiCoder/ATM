   M S B A M L   `   `   `  ����M  IMyFirstApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MyFirstApplicationMyFirstApplication  5      ,    &MyFirstApplication.DeleteAccountWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:MyFirstApplication     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��320��5      $	��200��5	        � 
ResizeMode$  NoResize=�5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��28* �6   �� 5      $��42 �6   �� 5      $	��30* �6   .+�5   
   �� $��0,5,0,0q�5      $��Center=�5      $��Center=�5      $��Poppins)�5      $��18(�5      $&�� To confirm, enter your password:��5      G� 5   
   -   5        $��userPassword��5       $��1��5!      $	��260��5"      $��33��5#      $��Center=�5$      $	��Top=�5%      $��Center=�5&      $��Center=�5'      $��Poppins)�5(      $��22(�5)      �� 5+   
   -   5        $��checkIfConfirmed��5,      $��2��5-      $��2��5.      $	��200��5/      $
��auto��50      $��29,0,0,0q�51      $
��Left=�52      $	��Top=�53      $'��!Are you sure you want to do this?��55       � Cursor$
 Hand��56      �� 58   
   -   5        $��enter��59      $��2��5:      $��55��5;      $��23��5<      $��0,18,0,0q�5=      $��Center=�5>      $��Center=�5?      $��Enter��5A      $
 Hand��5B      $��Poppins)�5C      $��14(�5D       �� 	IsDefault$
 true��5E      ${�false��5F      5I      5J      
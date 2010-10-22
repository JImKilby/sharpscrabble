﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Scrabble.Core;

namespace Scrabble.UI
{
    /// <summary>
    /// Interaction logic for Square.xaml
    /// </summary>
    public partial class BoardSquare : UserControl
    {
        public BoardSquare()
        {
            InitializeComponent();
        }

        public void Put(Tile sqToPlace)
        {
            if (PlacedTile == null)
                PlacedTile = sqToPlace;
            else
                throw new Exception("There's already a tile there.  Wrong game, dude.");
        }

        public void Redraw()
        {
            if (PlacedTile != null)
            {
                SquareContainer.Children.Clear();
                SquareContainer.Children.Add(PlacedTile);
            }
        }

        public Tile PlacedTile { get; set; }
    }
}

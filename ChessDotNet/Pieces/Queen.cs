﻿namespace ChessDotNet.Pieces
{
    public class Queen : ChessPiece
    {
        Player Owner
        {
            get;
            set;
        }

        public Queen(Player owner)
        {
            Owner = owner;
        }

        public override string GetFenCharacter()
        {
            return Owner == Player.White ? "Q" : "q";
        }
    }
}

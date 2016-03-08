﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LapinCretinsFormes
{
    class ShapeDataBase
    {

        private static List<Shape> shapesList = new List<Shape>();

        private static Random rand = new Random();

        static ShapeDataBase()
        {
            LoadShapes();
        }

        public static Shape GetRandomShape()
        {
            return shapesList[rand.Next(shapesList.Count)];
        }

        private static void LoadShapes()
        {
            string s =
                "M263.0 180.4 C263.0 180.6 266.4 190.4 270.6 202.1 C280.2 228.9 281.3 232.7 280.5 235.7 C279.9 238.2 279.9 238.2 274.2 237.0 C265.9 235.3 260.5 232.3 256.1 227.1 C251.8 221.9 250.8 219.9 248.6 211.6 C247.8 208.3 246.3 205.1 245.3 204.4 C243.2 202.8 243.1 202.9 242.6 207.8 L242.3 211.5 L242.9 207.6 C243.6 202.8 244.9 204.0 247.4 211.9 C250.1 220.4 251.0 222.2 255.6 227.6 C260.4 233.2 265.8 236.2 274.2 238.0 C279.9 239.2 280.0 239.2 281.1 236.6 C282.1 234.6 281.9 233.1 280.5 228.8 C269.6 197.5 265.0 183.5 265.3 182.7 C265.4 182.2 266.4 182.5 267.3 183.4 C268.2 184.4 269.0 184.7 269.0 184.1 C269.0 183.5 267.7 182.4 266.0 181.5 C264.4 180.6 263.0 180.1 263.0 180.4Z M271.5 192.5 C273.5 196.9 275.6 201.0 276.1 201.5 C276.7 202.1 275.5 198.9 273.5 194.5 C271.5 190.1 269.4 186.1 268.9 185.5 C268.3 185.0 269.5 188.1 271.5 192.5 Z M359.5 193.8 C359.2 195.3 356.3 199.8 353.1 203.7 C350.0 207.6 346.6 211.8 345.7 213.1 C344.0 215.7 342.0 226.5 342.0 233.7 C342.0 236.5 341.2 239.5 340.1 241.4 C339.0 243.1 336.7 249.4 335.0 255.4 C333.3 261.4 330.9 267.4 329.8 268.9 C327.1 272.4 313.2 282.3 312.0 281.5 C311.4 281.2 310.7 279.7 310.4 278.2 C310.0 276.6 309.8 276.3 309.8 277.6 C309.9 278.7 310.3 280.6 310.7 281.8 C311.5 283.9 311.8 283.8 320.5 278.5 C328.2 273.8 329.6 272.5 330.6 269.2 C333.9 258.8 339.3 244.2 341.1 241.4 C342.2 239.5 343.0 236.5 343.0 233.8 C343.0 229.9 344.2 223.9 347.5 211.5 C347.9 209.8 350.5 206.4 353.2 203.7 C356.2 200.8 358.8 197.3 359.6 194.7 C360.9 191.0 361.0 190.9 360.4 194.0 C360.1 195.9 359.0 199.1 358.0 201.0 C352.2 212.9 350.0 220.6 349.5 230.5 C349.3 235.9 349.3 240.6 349.5 240.8 C349.7 241.0 349.9 239.0 349.9 236.3 C349.9 233.7 350.4 229.1 351.0 226.2 C352.2 220.5 359.3 199.5 362.5 192.3 C362.8 191.6 362.4 191.0 361.6 191.0 C360.8 191.0 359.9 192.3 359.5 193.8Z M281.8 214.6 C286.6 225.6 286.7 225.6 286.2 214.4 C286.0 209.9 286.3 209.2 288.4 208.2 C291.3 206.9 290.7 205.3 299.1 236.2 C302.6 248.7 305.6 258.8 305.8 258.6 C306.3 258.1 294.6 215.1 292.5 209.7 L291.0 205.9 L288.0 207.5 C285.2 208.9 285.0 209.5 285.0 214.3 L285.1 219.5 L281.6 211.8 C279.7 207.5 277.9 204.0 277.6 204.0 C277.3 204.0 279.2 208.8 281.8 214.6Z M287.7 207.8 C289.4 206.4 289.6 206.5 291.1 209.4 C292.0 211.1 293.3 214.2 294.0 216.3 L294.0 216.3 L295.2 220.0 C287.5 220.0 287.0 219.7 287.0 217.6 C287.0 216.3 286.7 213.9 286.4 212.3 C286.0 210.2 286.3 209.0 287.7 207.8Z M242.5 213.3 C242.8 214.3 243.6 216.6 244.4 218.4 C245.2 220.3 246.3 224.2 246.9 227.2 C247.9 231.8 248.5 232.8 251.5 234.4 C253.4 235.5 255.2 237.1 255.5 238.1 C255.9 239.1 258.5 241.7 261.5 243.7 C266.6 247.3 266.8 247.6 265.2 249.3 C263.8 250.9 262.5 257.0 263.6 257.0 C263.8 257.0 266.4 255.8 269.4 254.3 L274.8 251.7 L279.3 255.4 C281.8 257.4 284.5 260.1 285.3 261.4 C287.1 264.0 292.4 289.1 294.1 302.5 C295.3 311.5 295.2 311.7 291.1 328.5 C284.4 355.6 283.1 361.8 281.5 374.5 C278.5 396.7 277.0 405.4 272.0 427.5 C269.3 439.6 267.2 449.6 267.4 449.7 C267.5 449.8 274.2 449.5 282.3 448.9 C295.0 448.0 297.6 448.0 301.7 449.4 C306.7 451.1 329.0 451.7 329.0 450.1 C329.0 449.7 326.5 442.0 323.5 433.1 L318.0 416.9 L317.5 390.2 C316.9 359.0 318.7 334.4 322.1 327.7 C323.2 325.6 325.0 320.2 326.1 315.8 C330.2 299.5 337.5 290.1 354.3 280.0 C358.8 277.3 362.4 275.3 362.2 275.6 C362.1 275.8 358.4 277.8 354.0 280.0 C344.0 285.0 333.9 294.3 330.0 302.0 C328.4 305.1 326.2 311.3 325.1 315.8 C324.0 320.2 322.2 325.6 321.1 327.7 C317.7 334.4 315.9 359.0 316.5 390.2 L317.0 416.9 L322.5 433.1 C325.5 442.0 328.0 449.4 328.0 449.6 C328.0 449.8 323.1 450.0 317.1 450.0 C308.4 450.0 305.3 449.6 301.4 447.9 C297.1 446.1 295.2 445.9 286.5 446.5 C281.0 446.8 274.6 447.5 272.3 448.1 L268.2 449.2 L273.1 427.3 C278.0 405.4 279.5 396.7 282.5 374.5 C284.1 361.8 285.4 355.6 292.1 328.5 C296.2 311.7 296.3 311.5 295.1 302.5 C293.2 287.7 288.0 263.8 285.9 260.9 C284.9 259.5 282.0 256.6 279.4 254.5 L274.8 250.7 L270.4 252.8 C265.1 255.4 265.4 255.4 264.6 253.3 C264.2 252.3 264.8 250.8 266.0 249.5 L268.1 247.3 L262.6 243.5 C259.5 241.4 256.8 238.9 256.5 237.9 C256.2 236.9 254.4 235.2 252.5 234.0 C248.8 231.7 247.2 229.0 247.0 224.9 C246.9 223.4 245.8 219.8 244.5 216.9 C243.2 213.9 242.3 212.3 242.5 213.3Z M401.4 221.6 C394.7 231.7 393.5 235.0 399.5 226.7 C401.7 223.6 403.7 221.3 403.9 221.5 C404.5 222.2 396.1 239.3 391.6 246.5 L387.1 253.5 L394.1 254.9 C404.7 257.0 403.3 257.9 387.3 259.5 C382.6 260.0 381.8 260.4 378.4 264.6 C375.9 267.6 372.6 270.1 368.8 271.9 L363.1 274.5 L368.6 272.6 C372.8 271.2 375.1 269.5 378.2 265.9 C382.0 261.3 382.7 261.0 387.9 260.4 C394.2 259.8 400.1 258.0 401.3 256.4 C401.8 255.6 400.2 255.1 396.0 254.6 C392.5 254.2 389.8 253.4 389.7 252.7 C389.6 252.0 391.4 248.3 393.7 244.5 C396.0 240.6 399.7 233.5 402.0 228.7 C404.2 223.8 406.7 218.8 407.5 217.7 C408.5 216.3 408.8 215.0 408.2 214.1 C407.5 213.1 405.8 215.0 401.4 221.6Z M402.0 222.3 C405.0 217.8 407.6 214.4 407.7 214.8 C407.8 215.2 407.1 216.2 406.0 217.0 C404.9 217.8 403.0 221.4 401.6 225.0 C399.3 231.4 396.9 234.6 396.6 231.8 C396.6 231.1 399.0 226.8 402.0 222.3Z M386.7 231.5 C385.8 232.6 384.2 235.7 383.2 238.3 C381.8 242.3 382.1 242.0 385.0 236.3 C386.9 232.6 387.7 230.4 386.7 231.5Z M390.6 229.2 C392.7 230.1 392.7 230.2 389.5 234.8 C385.6 240.5 384.8 246.0 388.0 246.0 C389.6 246.0 390.5 244.6 392.3 239.4 L394.5 232.8 L392.0 238.9 C389.5 245.1 386.4 247.7 387.9 242.2 C390.3 233.8 391.4 231.4 393.3 230.3 C395.2 229.1 395.1 229.0 391.9 228.6 C389.1 228.3 388.9 228.4 390.6 229.2Z M347.7 245.1 C346.8 249.5 345.0 256.1 343.0 262.3 C342.5 264.1 342.6 263.5 343.4 261.0 C344.2 258.5 345.7 255.1 346.9 253.4 C348.4 251.1 348.9 248.9 348.7 245.4 L348.5 240.7 L347.7 245.1Z M381.0 246.5 C381.0 246.1 378.4 249.0 375.3 252.8 L369.6 259.9 L358.0 264.0 C351.7 266.2 346.0 268.2 345.3 268.5 C344.7 268.8 343.7 268.2 343.2 267.3 C342.3 265.7 342.2 265.8 342.6 267.8 C343.1 270.4 342.2 270.5 358.1 264.9 L369.7 260.8 L375.4 254.0 C378.5 250.2 381.0 246.8 381.0 246.5Z M305.1 259.0 C304.9 259.8 309.1 275.4 309.6 275.9 C309.9 276.2 309.6 274.2 308.9 271.5 C307.5 265.7 305.2 258.3 305.1 259.0Z";
            shapesList.Add(new Shape(Geometry.Parse(s), new Uri("./Images/Cerisier.png", UriKind.Relative)));
        }

        public static void SaveShape(Shape shape)
        {
            shapesList.Add(shape);
        }
    }
}

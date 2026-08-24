using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomEngine.Core
{
    public class GameStateManager
    {
        private static GameStateManager _instance;

        private Stack<GameState> _screens = new Stack<GameState>();

        public static GameStateManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameStateManager();
                }
                return _instance;
            }
        }
        // Adds a new screen to the stack 
        public void AddState(GameState screen)
        {
            try
            {
                _screens.Push(screen);

                _screens.Peek().Initialize();
            }
            catch (Exception ex)
            {

            }
        }

        // Removes the top screen from the stack
        public void RemoveState()
        {
            if (_screens.Count > 0)
            {
                try
                {
                    var screen = _screens.Peek();
                    _screens.Pop();
                }
                catch (Exception ex)
                {

                }
            }
        }
        // Clears all the screen from the list
        public void ClearStates()
        {
            while (_screens.Count > 0)
            {
                _screens.Pop();
            }
        }
        // Removes all screens from the stack and adds a new one 
        public void SetState(GameState screen)
        {
            try
            {
                ClearStates();
                AddState(screen);
            }
            catch (Exception ex)
            {

            }
        }
        // Updates the top screen. 
        public void Update(GameTime gameTime)
        {
            try
            {
                if (_screens.Count > 0)
                {
                    _screens.Peek().Update(gameTime);
                }
            }
            catch (Exception ex)
            {

            }
        }

        // With how I want the engines systems I dont think manual drawing should be a thing atleast for now
        
        public void Draw()
        {
            try
            {
                if (_screens.Count > 0)
                {
                    _screens.Peek().Draw();
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        public void Destroy()
        {
            foreach (GameState state in _screens)
            {
                state.Destroy();
            }
        }
    }
}

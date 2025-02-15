import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import { createTheme, CssBaseline, ThemeProvider } from '@mui/material'
import { ContextProvider } from './hooks/useStateContext.jsx'

const darkTheme = createTheme({
  palette:{
    mode: 'dark'
  }
})

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <ContextProvider>
    <ThemeProvider theme={darkTheme}>
      <CssBaseline/>
      <App />
    </ThemeProvider>
    </ContextProvider>
  </StrictMode>,
)

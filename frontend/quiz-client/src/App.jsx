import './App.css'
import Login from './components/Login'
import {BrowserRouter, Route, Routes } from 'react-router-dom'
import Result from './components/Result'
import Quiz from './components/Quiz'
import Layout from './components/Layout'


function App() {
  return (
     <BrowserRouter>
        <Routes>
          <Route path='/' element={<Login/>}/>
          <Route path='/' element={<Layout/>}>
             <Route path='/quiz' element={<Quiz/>}/>
             <Route path='/result' element={<Result/>}/>
          </Route>   
        </Routes>
     </BrowserRouter>
  )
}

export default App

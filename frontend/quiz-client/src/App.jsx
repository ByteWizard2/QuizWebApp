import './App.css'
import Login from './components/Login'
import {BrowserRouter, Route, Routes } from 'react-router-dom'
import Result from './components/Result'
import Quiz from './components/Quiz'
import Layout from './components/Layout'
import Authenticate from './components/Authenticate'


function App() {
  return (
     <BrowserRouter>
        <Routes>
          <Route path='/' element={<Login/>}/>
          <Route element={<Authenticate/>}>
            <Route path='/' element={<Layout/>}>
               <Route path='/quiz' element={<Quiz/>}/>
               <Route path='/result' element={<Result/>}/>
            </Route>   
         </Route>
        </Routes>
     </BrowserRouter>
  )
}

export default App

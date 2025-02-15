import React, { useContext, useEffect, useState } from 'react'
import useStateContext, { stateContext } from '../hooks/useStateContext'
import { createAPIEndpoint,ENDPOINT } from '../api'

export default function Quiz() {

  const [qns, setQns] = useState([])

useEffect(()=>{
  createAPIEndpoint(ENDPOINT.question)
  .fetch()
  .then(res=>{
    setQns(res.data)
    console.log(res.data);
     
  })
  .catch(err=>{console.log(err);})
},[])
  
  return (
    <div>
      <h1>hlwww quizzzz</h1>
    </div>
  )
}

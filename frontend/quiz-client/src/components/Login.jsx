import React, { useState,useEffect } from 'react';
import TextField from '@mui/material/TextField';
import { Box, Button, Card, CardContent, Typography } from '@mui/material';
import Center from './Center';
import useForm from '../hooks/useForm';
import { createAPIEndpoint, ENDPOINT } from '../api';
import useStateContext from '../hooks/useStateContext';
import { useNavigate } from 'react-router-dom';

const getFreshModel = ()=>({
  name:'',
  email:''
})

export default function Login() {
   
   const {context,setContext,resetContext} = useStateContext();
   const navigate = useNavigate()

  const {
    values,
    setValues,
    errors,
    setErrors,
    handleInputChange

  }= useForm(getFreshModel);

  useEffect(()=>{
    resetContext(); 
  },[])

  const login= e =>{
    e.preventDefault();
    if(validate())
       createAPIEndpoint(ENDPOINT.participant)
      .post(values)
      .then(res =>{
         setContext({participantId: res.data.participantId})
         navigate('/quiz')
         
      } )
      .catch(err=> console.log(err))
    
  }
 
  const validate= () =>{
    let temp={}
    temp.email =(/\S+@\S+\.\S+/).test(values.email)?"":"Email is not valid."
    temp.name = values.name!=""?"":"This feald is required."
    setErrors(temp)
    return Object.values(temp).every(x=> x== "")
  }
 
  return (
    <Center>
    
      <Card sx={{width:400}}>
      <CardContent>
        <Typography variant="h3" sx={{my:3}}>
          Quize App</Typography>
      <Box sx={{
      '& .MuiTextField-root' :{
        m:1,
        width:'90%'
      }
    }}>
      
      <form noValidate autoComplete='off' onSubmit={login}> 
        <TextField label="Email" 
                   name="email" 
                   value={values.email}
                   onChange={handleInputChange} 
                   variant="outlined"
                   {...(errors.email && {error:true, helperText:errors.email})} />
        <TextField label="Name" 
                   name="name" 
                   value={values.name}
                   onChange={handleInputChange} 
                   variant="outlined" 
                   {...(errors.name && {error:true, helperText:errors.name})} />
        <Button type='submit' variant='contained' size='large' sx={{width:'90%'}}>Start</Button>
      </form>
    </Box>
      </CardContent>
    </Card>
    
       
    </Center>
    

 
  );
}

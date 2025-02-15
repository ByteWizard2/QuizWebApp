import { Grid, Grid2 } from '@mui/material'
import React from 'react'

export default function Center(props) {
  return (
 <Grid  container
    direction="column" alignItems="center" justifyContent="center" 
    sx={{minHeight:'100vh'}}>
    <Grid item xs={1}>
          {props.children}
    </Grid>
 </Grid>

 
  )
}

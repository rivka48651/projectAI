import React from 'react';
import logo from './logo.svg';
import './App.css';
import MovieList from './components/MovieList/MovieList';
import { AppBar, Box, Container, Toolbar, Typography } from '@mui/material';
import HomePage from './components/HomePage/HomePage';

function App() {
  return (
    <Box sx={{ display: 'flex', flexDirection: 'column', minHeight: '100vh' }}>
  <AppBar position="static" style={{ backgroundColor: '#fff', boxShadow: 'none' }}>
  <Toolbar style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '16px' }}>
    <Typography variant="h4" style={{ fontWeight: 'bold', color: '#2c3e50' }}>
      MOVIES4ALL
    </Typography>
    <Typography variant="h6" style={{ marginTop: 8, color: '#7f8c8d', fontStyle: 'italic' }}>
    Movies for all times and seasons   </Typography>
  </Toolbar>
</AppBar>
  <Container sx={{ flexGrow: 1, marginTop: '2rem' }}>
    <HomePage />
  </Container>

  <Box sx={{ flexShrink: 0, textAlign: 'center', padding: 2, background: '#f5f5f5', borderTop: '1px solid #ddd' }}>
    <Typography variant="body2" color="textSecondary">
      All rights reserved &copy; 2025 | Movies for the Haredi Community | Developed by Programming Group 3 Seminar Beit Yaakov Bnot Elisheva
    </Typography>
  </Box>
</Box>  );
}

export default App;

import * as React from 'react';
import Card from '@mui/material/Card';
import { Button, CardActionArea, CardActions, CardContent, CardMedia, Grid, Typography } from '@mui/material';

export default function NoteCard() {

    return (
        <Grid container spacing={3}>
            <Grid item xs="auto">
                <Card sx={{ maxWidth: 400, m: 1 }}>
                    <CardActionArea>
                        <CardMedia
                            component="img"
                            height="140"
                            image="https://via.placeholder.com/400"
                            alt="green iguana"
                        />
                        <CardContent>
                            <Typography gutterBottom variant="h5" component="div">
                                Asp.Net Core MVC
                            </Typography>
                            <Typography variant="body2" color="text.secondary">
                                Lizards are a widespread group of squamate reptiles, with over 6,000
                                species, ranging across all continents except Antarctica
                            </Typography>
                        </CardContent>
                    </CardActionArea>
                    <CardActions sx={{}}>
                      
                            <Button variant='contained'>
                                Paylaş
                            </Button>
                            <Button variant='contained'>
                                Daha Fazla...
                            </Button>
                    </CardActions>

                </Card>
            </Grid>
            <Grid item xs="auto">
                <Card sx={{ maxWidth: 400, m: 1 }}>
                    <CardActionArea>
                        <CardMedia
                            component="img"
                            height="140"  
                            image="https://via.placeholder.com/400"
                            alt="green iguana"
                        />
                        <CardContent>
                            <Typography gutterBottom variant="h5" component="div">
                                Asp.Net Core MVC
                            </Typography>
                            <Typography variant="body2" color="text.secondary">
                                Lizards are a widespread group of squamate reptiles, with over 6,000
                                species, ranging across all continents except Antarctica
                            </Typography> 
                        </CardContent>
                    </CardActionArea>
                    <CardActions sx={{}}>
                      
                            <Button variant='contained'>
                                Paylaş 
                            </Button>
                            <Button variant='contained'>
                                Daha Fazla...
                            </Button>
                    </CardActions>

                </Card>
            </Grid>
            <Grid item xs="auto">
                <Card sx={{ maxWidth: 400, m: 1 }}>
                    <CardActionArea>
                        <CardMedia
                            component="img"
                            height="140"
                            image="https://via.placeholder.com/400"
                            alt="green iguana"
                        />
                        <CardContent>
                            <Typography gutterBottom variant="h5" component="div">
                                Asp.Net Core MVC
                            </Typography>
                            <Typography variant="body2" color="text.secondary">
                                Lizards are a widespread group of squamate reptiles, with over 6,000
                                species, ranging across all continents except Antarctica
                            </Typography>
                        </CardContent>
                    </CardActionArea>
                    <CardActions sx={{}}>
                      
                            <Button variant='contained'>
                                Paylaş
                            </Button>
                            <Button variant='contained'>
                                Daha Fazla...
                            </Button>
                    </CardActions>

                </Card>
            </Grid>
        </Grid>

    );

}
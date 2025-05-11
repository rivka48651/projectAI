import React, { JSX, lazy, Suspense } from 'react';
import { MovieObject } from 'src/models/Movie';

const LazyMovie = lazy(() => import('./Movie'));

const Movie = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyMovie movie={undefined} handleSelectMovie={function (movie: MovieObject): void {
      throw new Error('Function not implemented.');
    } } {...props} />
  </Suspense>
);

export default Movie;

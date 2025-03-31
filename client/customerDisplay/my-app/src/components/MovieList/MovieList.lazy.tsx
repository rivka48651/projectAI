import React, { JSX, lazy, Suspense } from 'react';
const LazyMovieList = lazy(() => import('./MovieList'));

const MovieList = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyMovieList movies={[]} {...props} />
  </Suspense>
);

export default MovieList;

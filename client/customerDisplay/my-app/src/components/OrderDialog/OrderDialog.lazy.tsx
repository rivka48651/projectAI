import React, { JSX, lazy, Suspense } from 'react';

const LazyOrderDialog = lazy(() => import('./OrderDialog'));

const OrderDialog = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyOrderDialog open={false} onClose={function (): void {
      throw new Error('Function not implemented.');
    } } onSubmit={function (email: string): void {
      throw new Error('Function not implemented.');
    } } {...props} />
  </Suspense>
);

export default OrderDialog;

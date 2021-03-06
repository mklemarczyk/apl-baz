<?php

use yii\helpers\Html;
use yii\grid\GridView;

/* @var $this yii\web\View */
/* @var $searchModel frontend\models\ZakupSearch */
/* @var $dataProvider yii\data\ActiveDataProvider */

$this->title = 'Zakupy';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="zakup-index">

    <h1><?= Html::encode($this->title) ?></h1>
    <?php // echo $this->render('_search', ['model' => $searchModel]); ?>

    <p>
        <?= Html::a('Stwórz zakup', ['create'], ['class' => 'btn btn-success']) ?>
    </p>

    <?= GridView::widget([
        'dataProvider' => $dataProvider,
        'filterModel' => $searchModel,
        'columns' => [
            ['class' => 'yii\grid\SerialColumn'],

            // 'id',
            'data_zakupu:datetime',
            'klient.nazwa:text:Klient',

            ['class' => 'yii\grid\ActionColumn'],
        ],
    ]); ?>

</div>

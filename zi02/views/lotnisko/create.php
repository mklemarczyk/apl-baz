<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model app\models\Lotnisko */

$this->title = 'Create Lotnisko';
$this->params['breadcrumbs'][] = ['label' => 'Lotniskos', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="lotnisko-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
